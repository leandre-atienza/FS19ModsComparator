using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace FS19ModsComparator
{
    class ModsProcessor
    {
        private string modsDirectoryPath;
        private Dictionary<string, string> mods;
        public ModsProcessor(string modsDirectoryPath)
        {
            this.modsDirectoryPath = modsDirectoryPath;
            mods = getMods();
        }

        private Dictionary<string, string> getMods()
        {
            var archives = System.IO.Directory.EnumerateFiles(modsDirectoryPath)

                                                 .Where<string>(file => file.EndsWith(".zip") /*|| file.EndsWith(".rar")*/);
            Dictionary<string, string> mods = new Dictionary<string, string>();

            foreach (string archive in archives)
            {
                ZipArchive zipArchive = ZipFile.OpenRead(archive);
                IEnumerable<ZipArchiveEntry> modDescArchiveEntries = zipArchive.Entries.Where<ZipArchiveEntry>(File => File.Name == "modDesc.xml");
                if (modDescArchiveEntries.Count<ZipArchiveEntry>() > 0)
                {
                    ZipArchiveEntry modDescArchiveEntry = modDescArchiveEntries.First();
                    string modDescFileContent;
                    using (Stream stream = modDescArchiveEntry.Open())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            modDescFileContent = reader.ReadToEnd();
                        }
                    }

                    string hashcode = ComputeSha256Hash(modDescFileContent);
                    if (!mods.Keys.Contains<string>(hashcode))
                    {
                        mods.Add(hashcode, archive);
                    }
                }
            }

            return mods;
        }

        public void export(string pathToSave)
        {
            string[] lines = mods.Keys.ToArray<string>();
            File.WriteAllLines(pathToSave, lines);
        }

        public bool scan(string pathToSource, string pathToFile)
        {
            string[] sourceLines = File.ReadAllLines(pathToSource);
            string[] lines = sourceLines.Where<string>(line => !mods.Keys.Contains<string>(line)).ToArray<string>();
            if (lines.Length > 0)
            {
                File.WriteAllLines(pathToFile, lines);
                return true;
            }

            return false;
        }

        public bool Pack(string pathToSource, string pathToPack)
        {
            string[] sourceLines = File.ReadAllLines(pathToSource);
            if (sourceLines.Length > 0)
            {
                ProgressForm progress = new ProgressForm(sourceLines.Length);
                progress.Show();

                string packPath = pathToPack + "\\ModsMissing_Pack_" + DateTime.Now.Date.ToString().Replace('.', '-').Split(' ')[0] + "_" + DateTime.Now.ToShortTimeString().Replace(':', '-');
                Trace.WriteLine(packPath);
                System.IO.Directory.CreateDirectory(packPath);
                foreach (string line in sourceLines)
                {
                    progress.setCurrentValue(progress.getCurrentValue() + 1);
                    if (mods.ContainsKey(line))
                    {
                        string file = mods[line];
                        progress.setCurrentLabel(progress.getCurrentValue() + "/" + sourceLines.Length + " - " + file);
                        System.IO.File.Copy(file, packPath + "\\" + file.Split('\\').Last<string>());
                    }
                }

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = packPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);

                progress.Close();

                return true;
            }

            return false;
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
