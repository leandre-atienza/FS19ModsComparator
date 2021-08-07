using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS19ModsComparator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (FolderExists(ModsPath))
                txt_path.Text = ModsPath;
            else
                txt_path.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            ResizeTabsPanels();
        }

        #region Properties
        #region Private
        /// <summary>
        /// Path to the mods directory
        /// </summary>
        private readonly string ModsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\FarmingSimulator2019\\mods";
        /// <summary>
        /// Mods processor instance
        /// </summary>
        private ModsProcessor modsProcessor;
        #endregion
        #endregion

        #region Functions
        /// <summary>
        /// Check if a specified directory exists
        /// </summary>
        /// <param name="path">path to the directory</param>
        /// <returns>true if directory exists</returns>
        private bool FolderExists(string path)
        {
            return System.IO.Directory.Exists(path);
        }

        /// <summary>
        /// Resize Tabs with Panels Sizes
        /// </summary>
        private void ResizeTabsPanels()
        {
            Panel currentPanel = (Panel)Controls.Find("pnl_" + tab_exportScanPack.SelectedTab.Name, true)[0];
            tab_exportScanPack.SelectedTab.Size = new Size
            {
                Height = currentPanel.Size.Height,
                Width = currentPanel.Size.Width
            };

            tab_exportScanPack.Size = new Size
            {
                Height = currentPanel.Size.Height + 30,
                Width = currentPanel.Size.Width + 10
            };
        }
        #endregion

        #region Events

        private void btn_browse_Click(object sender, EventArgs e)
        {
           using(var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select your farming simulator 2019 mods folder.";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    txt_path.Text = dialog.SelectedPath;
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            pnl_selectModsFolder.Visible = false;
            pnl_exportOrCompare.Visible = true;
            this.modsProcessor = new ModsProcessor(ModsPath);         
        }

        private void txt_path_TextChanged(object sender, EventArgs e)
        {
            if (FolderExists(txt_path.Text))
            {
                txt_path.ForeColor = Color.Black;
                btn_next.Enabled = true;
            } else
            {
                txt_path.ForeColor = Color.Red;
                btn_next.Enabled = false;
            }
        }

        private void tab_exportScanPack_Selected(object sender, TabControlEventArgs e)
        {
            ResizeTabsPanels();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.FileName = "ModsList.txt";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.DefaultExt = "txt";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    modsProcessor.export(dialog.FileName);
                }
            }

            MessageBox.Show("Mods list file exported. Share it.");
        }

        #endregion

        private void btn_scan_Click(object sender, EventArgs e)
        {
            string modsListPath = "";
            using (var dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.FileName = "ModsList.txt";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.DefaultExt = "txt";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    modsListPath = dialog.FileName;
                }
            }

            string modsMissingListPath = "";
            using (var dialog = new SaveFileDialog())
            {
                dialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.FileName = "ModsMissingList.txt";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.DefaultExt = "txt";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    modsMissingListPath = dialog.FileName;

                }
            }

            if (!modsProcessor.scan(modsListPath, modsMissingListPath))
            {
                MessageBox.Show("No mods missing");
            }
            else
            {
                MessageBox.Show("Missing mods list file exported.");
            }
        }

        private void btn_pack_Click(object sender, EventArgs e)
        {
            string modsMissingListPath = "";
            using (var dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.FileName = "ModsList.txt";
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.DefaultExt = "txt";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    modsMissingListPath = dialog.FileName;
                }
            }

            string zipToSaVe = "";
            using (var dialog = new SaveFileDialog())
            {
                dialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.FileName = "MissingMods_Pack.zip";
                dialog.Filter = "Archive files (*.zip)|*.zip";
                dialog.DefaultExt = "zip";
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    zipToSaVe = dialog.FileName;
                }
            }

            if (zipToSaVe != "" && modsMissingListPath != "")
            {

                if (!modsProcessor.Pack(modsMissingListPath, zipToSaVe))
                {
                    MessageBox.Show("No mods missing");
                }
                else
                {
                    MessageBox.Show("Missing mods list zip created.");
                }
            }
        }
    }
}
