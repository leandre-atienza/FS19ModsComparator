
namespace FS19ModsComparator
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.pnl_selectModsFolder = new System.Windows.Forms.Panel();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.lbl_selectModsFolder = new System.Windows.Forms.Label();
            this.pnl_exportOrCompare = new System.Windows.Forms.Panel();
            this.tab_exportScanPack = new System.Windows.Forms.TabControl();
            this.tabp_export = new System.Windows.Forms.TabPage();
            this.pnl_tabp_export = new System.Windows.Forms.Panel();
            this.btn_export = new System.Windows.Forms.Button();
            this.lbl_export = new System.Windows.Forms.Label();
            this.tabp_scan = new System.Windows.Forms.TabPage();
            this.pnl_tabp_scan = new System.Windows.Forms.Panel();
            this.btn_scan = new System.Windows.Forms.Button();
            this.lbl_scan = new System.Windows.Forms.Label();
            this.tabp_pack = new System.Windows.Forms.TabPage();
            this.pnl_tabp_pack = new System.Windows.Forms.Panel();
            this.btn_pack = new System.Windows.Forms.Button();
            this.lbl_pack = new System.Windows.Forms.Label();
            this.pnl_selectModsFolder.SuspendLayout();
            this.pnl_exportOrCompare.SuspendLayout();
            this.tab_exportScanPack.SuspendLayout();
            this.tabp_export.SuspendLayout();
            this.pnl_tabp_export.SuspendLayout();
            this.tabp_scan.SuspendLayout();
            this.pnl_tabp_scan.SuspendLayout();
            this.tabp_pack.SuspendLayout();
            this.pnl_tabp_pack.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(352, 27);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(352, 54);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // pnl_selectModsFolder
            // 
            this.pnl_selectModsFolder.Controls.Add(this.txt_path);
            this.pnl_selectModsFolder.Controls.Add(this.btn_browse);
            this.pnl_selectModsFolder.Controls.Add(this.lbl_selectModsFolder);
            this.pnl_selectModsFolder.Controls.Add(this.btn_next);
            this.pnl_selectModsFolder.Location = new System.Drawing.Point(8, 8);
            this.pnl_selectModsFolder.Name = "pnl_selectModsFolder";
            this.pnl_selectModsFolder.Size = new System.Drawing.Size(430, 88);
            this.pnl_selectModsFolder.TabIndex = 3;
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(6, 28);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(343, 20);
            this.txt_path.TabIndex = 4;
            this.txt_path.TextChanged += new System.EventHandler(this.txt_path_TextChanged);
            // 
            // lbl_selectModsFolder
            // 
            this.lbl_selectModsFolder.AutoSize = true;
            this.lbl_selectModsFolder.Location = new System.Drawing.Point(3, 11);
            this.lbl_selectModsFolder.Name = "lbl_selectModsFolder";
            this.lbl_selectModsFolder.Size = new System.Drawing.Size(117, 13);
            this.lbl_selectModsFolder.TabIndex = 3;
            this.lbl_selectModsFolder.Text = "Select your mods folder";
            // 
            // pnl_exportOrCompare
            // 
            this.pnl_exportOrCompare.AutoSize = true;
            this.pnl_exportOrCompare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_exportOrCompare.Controls.Add(this.tab_exportScanPack);
            this.pnl_exportOrCompare.Location = new System.Drawing.Point(8, 8);
            this.pnl_exportOrCompare.Name = "pnl_exportOrCompare";
            this.pnl_exportOrCompare.Size = new System.Drawing.Size(509, 101);
            this.pnl_exportOrCompare.TabIndex = 4;
            this.pnl_exportOrCompare.Visible = false;
            // 
            // tab_exportScanPack
            // 
            this.tab_exportScanPack.Controls.Add(this.tabp_export);
            this.tab_exportScanPack.Controls.Add(this.tabp_scan);
            this.tab_exportScanPack.Controls.Add(this.tabp_pack);
            this.tab_exportScanPack.Location = new System.Drawing.Point(5, 4);
            this.tab_exportScanPack.Name = "tab_exportScanPack";
            this.tab_exportScanPack.SelectedIndex = 0;
            this.tab_exportScanPack.Size = new System.Drawing.Size(501, 94);
            this.tab_exportScanPack.TabIndex = 0;
            this.tab_exportScanPack.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_exportScanPack_Selected);
            // 
            // tabp_export
            // 
            this.tabp_export.Controls.Add(this.pnl_tabp_export);
            this.tabp_export.Location = new System.Drawing.Point(4, 22);
            this.tabp_export.Name = "tabp_export";
            this.tabp_export.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_export.Size = new System.Drawing.Size(493, 68);
            this.tabp_export.TabIndex = 0;
            this.tabp_export.Text = "Export";
            this.tabp_export.UseVisualStyleBackColor = true;
            // 
            // pnl_tabp_export
            // 
            this.pnl_tabp_export.AutoSize = true;
            this.pnl_tabp_export.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_tabp_export.Controls.Add(this.btn_export);
            this.pnl_tabp_export.Controls.Add(this.lbl_export);
            this.pnl_tabp_export.Location = new System.Drawing.Point(0, 1);
            this.pnl_tabp_export.Name = "pnl_tabp_export";
            this.pnl_tabp_export.Size = new System.Drawing.Size(420, 64);
            this.pnl_tabp_export.TabIndex = 5;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(173, 38);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 0;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // lbl_export
            // 
            this.lbl_export.AutoSize = true;
            this.lbl_export.Location = new System.Drawing.Point(3, 9);
            this.lbl_export.Name = "lbl_export";
            this.lbl_export.Size = new System.Drawing.Size(414, 26);
            this.lbl_export.TabIndex = 1;
            this.lbl_export.Text = "Export your mods list and share it to somebody.\r\nHe need to scan it in this app o" +
    "n the scan tab and give you back the missing mods list.\r\n";
            // 
            // tabp_scan
            // 
            this.tabp_scan.Controls.Add(this.pnl_tabp_scan);
            this.tabp_scan.Location = new System.Drawing.Point(4, 22);
            this.tabp_scan.Name = "tabp_scan";
            this.tabp_scan.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_scan.Size = new System.Drawing.Size(493, 68);
            this.tabp_scan.TabIndex = 1;
            this.tabp_scan.Text = "Scan";
            this.tabp_scan.UseVisualStyleBackColor = true;
            // 
            // pnl_tabp_scan
            // 
            this.pnl_tabp_scan.AutoSize = true;
            this.pnl_tabp_scan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_tabp_scan.Controls.Add(this.btn_scan);
            this.pnl_tabp_scan.Controls.Add(this.lbl_scan);
            this.pnl_tabp_scan.Location = new System.Drawing.Point(0, 1);
            this.pnl_tabp_scan.Name = "pnl_tabp_scan";
            this.pnl_tabp_scan.Size = new System.Drawing.Size(495, 68);
            this.pnl_tabp_scan.TabIndex = 5;
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(210, 42);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(75, 23);
            this.btn_scan.TabIndex = 1;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // lbl_scan
            // 
            this.lbl_scan.AutoSize = true;
            this.lbl_scan.Location = new System.Drawing.Point(3, 9);
            this.lbl_scan.Name = "lbl_scan";
            this.lbl_scan.Size = new System.Drawing.Size(489, 26);
            this.lbl_scan.TabIndex = 0;
            this.lbl_scan.Text = "Scan for missing mods with the mods list of somebody.\r\nSave the missing mods list" +
    " file and share it back to the author of the mods list file to get the mods pack" +
    ".";
            // 
            // tabp_pack
            // 
            this.tabp_pack.Controls.Add(this.pnl_tabp_pack);
            this.tabp_pack.Location = new System.Drawing.Point(4, 22);
            this.tabp_pack.Name = "tabp_pack";
            this.tabp_pack.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_pack.Size = new System.Drawing.Size(493, 68);
            this.tabp_pack.TabIndex = 2;
            this.tabp_pack.Text = "Pack";
            this.tabp_pack.UseVisualStyleBackColor = true;
            // 
            // pnl_tabp_pack
            // 
            this.pnl_tabp_pack.AutoSize = true;
            this.pnl_tabp_pack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_tabp_pack.Controls.Add(this.btn_pack);
            this.pnl_tabp_pack.Controls.Add(this.lbl_pack);
            this.pnl_tabp_pack.Location = new System.Drawing.Point(3, 3);
            this.pnl_tabp_pack.Name = "pnl_tabp_pack";
            this.pnl_tabp_pack.Size = new System.Drawing.Size(234, 60);
            this.pnl_tabp_pack.TabIndex = 5;
            // 
            // btn_pack
            // 
            this.btn_pack.Location = new System.Drawing.Point(80, 34);
            this.btn_pack.Name = "btn_pack";
            this.btn_pack.Size = new System.Drawing.Size(75, 23);
            this.btn_pack.TabIndex = 1;
            this.btn_pack.Text = "Pack";
            this.btn_pack.UseVisualStyleBackColor = true;
            this.btn_pack.Click += new System.EventHandler(this.btn_pack_Click);
            // 
            // lbl_pack
            // 
            this.lbl_pack.AutoSize = true;
            this.lbl_pack.Location = new System.Drawing.Point(3, 4);
            this.lbl_pack.Name = "lbl_pack";
            this.lbl_pack.Size = new System.Drawing.Size(228, 26);
            this.lbl_pack.TabIndex = 0;
            this.lbl_pack.Text = "Select the missing mods list file from somebody.\r\nIt will create a zip file with " +
    "all missing mods.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(918, 594);
            this.Controls.Add(this.pnl_exportOrCompare);
            this.Controls.Add(this.pnl_selectModsFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Farming Simulator 19 Mods Comparator by Lezada";
            this.pnl_selectModsFolder.ResumeLayout(false);
            this.pnl_selectModsFolder.PerformLayout();
            this.pnl_exportOrCompare.ResumeLayout(false);
            this.tab_exportScanPack.ResumeLayout(false);
            this.tabp_export.ResumeLayout(false);
            this.tabp_export.PerformLayout();
            this.pnl_tabp_export.ResumeLayout(false);
            this.pnl_tabp_export.PerformLayout();
            this.tabp_scan.ResumeLayout(false);
            this.tabp_scan.PerformLayout();
            this.pnl_tabp_scan.ResumeLayout(false);
            this.pnl_tabp_scan.PerformLayout();
            this.tabp_pack.ResumeLayout(false);
            this.tabp_pack.PerformLayout();
            this.pnl_tabp_pack.ResumeLayout(false);
            this.pnl_tabp_pack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Panel pnl_selectModsFolder;
        private System.Windows.Forms.Label lbl_selectModsFolder;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Panel pnl_exportOrCompare;
        private System.Windows.Forms.TabControl tab_exportScanPack;
        private System.Windows.Forms.TabPage tabp_export;
        private System.Windows.Forms.TabPage tabp_scan;
        private System.Windows.Forms.TabPage tabp_pack;
        private System.Windows.Forms.Label lbl_export;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Label lbl_scan;
        private System.Windows.Forms.Panel pnl_tabp_export;
        private System.Windows.Forms.Panel pnl_tabp_scan;
        private System.Windows.Forms.Panel pnl_tabp_pack;
        private System.Windows.Forms.Button btn_pack;
        private System.Windows.Forms.Label lbl_pack;
    }
}

