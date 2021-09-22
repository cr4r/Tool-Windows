using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Tool_Windows.tools.AndroidTool
{
    public partial class ADB : UserControl
    {
        Process process = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo();

        public ADB()
        {
            InitializeComponent();
            rtbConsole.ScrollBars = RichTextBoxScrollBars.Both;
        }

        private void dialogOpenFile(string filter = "Semua File|*", Guna2TextBox textBox = null)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = filter;
            openFile.Title = "Buka File...";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = openFile.FileName;
            }
        }

        private void dialogOpenFolder(Guna2TextBox textBox, string path="", string deskripsi = "Lokasi untuk backup")
        {
            FolderBrowserDialog backupFolder = new FolderBrowserDialog();
            backupFolder.Description = deskripsi;
            if(backupFolder.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = backupFolder.SelectedPath + path;
            }
        }

        private void runCMD(string argumen = "install", string fileName = null)
        {
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = 
            startInfo.Arguments = $" {argumen}";
            process.StartInfo = startInfo;
            process.Start();
            printConsole($"{argumen}\n{process.StandardOutput.ReadToEnd()}");
        }

        private void printConsole(string pesan)
        {
            rtbConsole.Text = $"{rtbConsole.Text} {pesan}\n>> ";
        }

        private void btnBrowseInstallApk_Click(object sender, EventArgs e)
        {
            dialogOpenFile("APK|*.apk", txtInstallApk);
        }

        private void btnInstallApk_Click(object sender, EventArgs e)
        {
            runCMD($"install {txtInstallApk.Text}");
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            dialogOpenFolder(txtBackup, "\\backup.bak");
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            runCMD($"/c adb.exe backup -f {txtBackup.Text} -all -apk -nosystem", @"C:\Windows\System32\cmd.exe");
        }

        private void btnBrowseSideload_Click(object sender, EventArgs e)
        {
            dialogOpenFile("ZIP files|*.zip",txtSideload);
        }

        private void btnSideload_Click(object sender, EventArgs e)
        {
            runCMD($"sideload {txtSideload.Text}");
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            runCMD("reboot");
        }

        private void btnRebootRecovery_Click(object sender, EventArgs e)
        {
            runCMD("reboot recovery");
        }

        private void btnRecoveryBootloader_Click(object sender, EventArgs e)
        {
            runCMD("reboot bootloader");
        }

        private void btnAdbDevices_Click(object sender, EventArgs e)
        {
            runCMD("devices");
        }

        private void btnkillServer_Click(object sender, EventArgs e)
        {
            runCMD("kill-server");
        }

        private void btnIpDevices_Click(object sender, EventArgs e)
        {
            bool c = Kelas.MainControllClass.IsValidateIP(txtIpDevices.Text);
            if (c)
            {
                runCMD("kill-server");
                runCMD("tcpip 5555");
                runCMD($"connect {txtIpDevices.Text}");
            }
            else
            {
                printConsole("Maaf ip tidak valid!");
            }
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            rtbConsole.Text = ">> ";
        }

        private void btnHelpIADB_Click(object sender, EventArgs e)
        {
            Help.HelpToolADB helpADB = new Help.HelpToolADB();
            helpADB.Show();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            if (gbAdvanced.Visible)
            {
                gbAdvanced.Visible = false;
            }
            else
            {
                gbAdvanced.Visible = true;
            }
        }
    }
}
