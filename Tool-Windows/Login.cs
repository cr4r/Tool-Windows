using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using Tool_Windows.Database;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Threading;

namespace Tool_Windows
{
    public partial class Login : Form
    {
        string allowChars = @"^[a-zA-Z0-9]*$";
        Connection koneksi = new Connection();

        public Login()
        {
            InitializeComponent();
        }
        public async void cekAkun()
        {
            if (txtUsername.Text.Length > 2 && txtPassword.Text.Length > 2 && Regex.IsMatch(txtUsername.Text, allowChars))
            {
                try
                {
                    if (koneksi.konekDB())
                    {
                        var db = koneksi.client.GetDatabase("blog");
                        var akun = db.GetCollection<BsonDocument>("akuns");

                        var getCrypt = await Connection.getApi($"/crypto/encrypt?q={txtPassword.Text}");
                        var hasil = JsonConvert.DeserializeObject<Dictionary<string, string>>(getCrypt);

                        var filter = new BsonDocument { { "username", txtUsername.Text }, { "password", hasil["result"] } };

                        var documents = akun.Find(filter).FirstOrDefault();

                        if (documents != null)
                        {
                            this.Hide();
                            Home home = new Home();
                            home.Show();
                        }
                        else
                        {
                            MessageBox.Show("Periksa Kembali Username dan Password anda", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Koneksi anda terputus!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    MessageBox.Show("Koneksi anda terputus!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Masukkan username dan password yang benar!", "Kesalahan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblDaftar_Click(object sender, EventArgs e)
        {

        }

        private void lblLupaPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (bgw1.IsBusy == false)
            {
                progressLoad.Visible = true;
                progressLoad.AutoStart = true;
                plMemberLogin.Enabled = false;
                bgw1.RunWorkerAsync();
            }
        }

        private void bgw1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            cekAkun();
            /*bgw1.ReportProgress(ab);*/
        }

        private void bgw1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            /*Gunakan kode logic loding disini*/
            cekAkun();
        }

        private void bgw1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressLoad.Visible = false;
            progressLoad.AutoStart = false;
            plMemberLogin.Enabled = true;
        }
    }
}
