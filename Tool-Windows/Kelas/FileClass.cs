using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tool_Windows.Kelas
{
    class FileClass
    {
        OpenFileDialog openFile = new OpenFileDialog();
        FolderBrowserDialog backupFolder = new FolderBrowserDialog();
        string fileName;

        public void copy(string source, string target, BackgroundWorker worker = null)
        {
            FileStream fsOut = new FileStream(target, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);
            byte[] bt = new byte[1048756];
            int readByte;

            while((readByte = fsIn.Read(bt, 0, bt.Length)) > 0)
            {
                fsOut.Write(bt, 0, readByte);
                worker.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
            }

            fsIn.Close();
            fsOut.Close();
        }

        public void dialogOpenFile(string filter = "Semua File|*", bool multiFile = false, Guna2TextBox textBox = null, ListBox listBox = null)
        {
            openFile.Multiselect = multiFile;
            openFile.Filter = filter;
            openFile.Title = "Pilih File";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (textBox != null)
                {
                    textBox.Text = "";
                    if (multiFile)
                    {
                        foreach (String file in openFile.FileNames)
                        {
                            fileName += file + ";";
                        }
                        fileName = fileName.Replace(" ", "\\ ");
                    }
                    else
                    {
                        fileName = openFile.FileName;
                    }

                    textBox.Text = fileName;
                }
                else
                {
                    listBox.Items.AddRange(openFile.FileNames);
                }
            }
        }

        public void dialogOpenFolder(Guna2TextBox textBox, string path = "", string deskripsi = "Lokasi untuk backup")
        {
            backupFolder.Description = deskripsi;
            if (backupFolder.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = backupFolder.SelectedPath + path;
            }
        }

        public void buatFile(string fileName = "", string isiFile = "")
        {
            try
            {
                /*FileInfo fi = new FileInfo(fileName);*/

                if (cekFolder(fileName))
                {
                    File.WriteAllText(fileName, isiFile);
                }
                else
                {
                    MessageBox.Show("Gagal Membuat Folder", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
        }

        public bool cekFolder(string file = "")
        {
            string folderName = Path.GetDirectoryName(file);
            try
            {
                if (!Directory.Exists(folderName))
                {
                    Directory.CreateDirectory(folderName);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void writeFile(string fileName, string text = "")
        {
            DialogResult tanyaHapusFile = MessageBox.Show("File sudah ada, apakah anda ingin menimpanya?", "Timpa File", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (DialogResult.Yes == tanyaHapusFile)
            {
                FileInfo fi = new FileInfo(fileName);

                fi.Delete();
                using (FileStream fs = File.Create(fileName))
                {
                    File.WriteAllText(fileName, text);
                };
            }
        }

        public string bacaFile(string fileName = "")
        {
            if (File.Exists(fileName))
            {
                return File.ReadAllText(fileName);
            }
            return string.Empty;
        }

        public string convertDictToStr(IDictionary dict)
        {
            string dictionaryString = "{";
            foreach (DictionaryEntry keyValues in dict)
            {
                dictionaryString += keyValues.Key + " : " + keyValues.Value + ", ";
            }
            return dictionaryString.TrimEnd(',', ' ') + "}";
        }
    }
}
