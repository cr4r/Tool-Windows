using System;
using System.Linq;
using System.Windows.Forms;
using Tool_Windows.Database;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Tool_Windows.Kelas;
using Guna.UI2.WinForms;
using System.Drawing;

namespace Tool_Windows
{
    public partial class Login : Form
    {
        string allowChars = @"^[a-zA-Z0-9]*$", gender = "0";
        Connection koneksi = new Connection();

        public Login()
        {
            InitializeComponent();
        }

        private void cekPassword(string pwd1, string pwd2)
        {
            bool isPassword = pwd1 == pwd2 && txtPasswordDaftar.Text != string.Empty && txtRepasswordDaftar.Text != string.Empty;
            hideWarning(isPassword, warningPassword);
        }

        private void hideWarning(bool cek, Guna2PictureBox GPB)
        {
            if (!cek)
            {
                GPB.Visible = true;
            }
            else
            {
                GPB.Visible = false;
            }
        }

        private async void cekFormDaftar()
        {
            bool email = txtEmail.Text != string.Empty && MainControllClass.isEmail(txtEmail.Text);
            bool username = txtUsernameDaftar.Text != string.Empty;
            bool password = txtPasswordDaftar.Text != string.Empty && txtRepasswordDaftar.Text != string.Empty && txtRepasswordDaftar.Text == txtPasswordDaftar.Text;
            if (email && username && password)
            {
                try
                {
                    if (cbGender.Text.Equals("Laki-Laki"))
                    {
                        gender = "0";
                    }
                    else
                    {
                        gender = "1";
                    }

                    if (await koneksi.konekDB())
                    {
                        var inputData = new Dictionary<string, string>
                        {
                            { "nama", txtNama.Text },
                            { "email", txtEmail.Text },
                            { "gender", gender},
                            { "username", txtUsernameDaftar.Text },
                            { "password", txtPasswordDaftar.Text },
                            { "repassword", txtRepasswordDaftar.Text }
                        };

                        var postData = await Connection.postApi(inputData, "/daftar");
                        var hasil = JsonConvert.DeserializeObject<Dictionary<string, string>>(postData);

                        if (hasil["status"] == "ok")
                        {
                            MessageBox.Show($@"Anda berhasil terdaftar!\n{hasil["result"]}", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            /*this.Hide();
                            Home home = new Home();
                            home.Show();*/
                        }
                        else
                        {
                            MessageBox.Show($@"{hasil["result"]}", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                } catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            btnDaftar.Enabled = true;
            btnDaftar.UseWaitCursor = false;
        }

        public async void cekAkun()
        {
            if (txtUsername.Text.Length > 2 && txtPassword.Text.Length > 2 && Regex.IsMatch(txtUsername.Text, allowChars))
            {
                try
                {
                    if (await koneksi.konekDB())
                    {
                        var inputData = new Dictionary<string, string> { { "username", txtUsername.Text }, { "password", txtPassword.Text } };
                        var postData = await Connection.postApi(inputData, "/login");
                        var hasil = JsonConvert.DeserializeObject<Dictionary<string, string>>(postData);

                        if (hasil["status"] == "ok")
                        {
                            Home home = new Home();
                            home.Show();
                            this.Close();
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
            btnLogin.Enabled = true;
            btnLogin.UseWaitCursor = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void bgw1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            cekAkun();
            /*bgw1.ReportProgress(ab);*/
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnLogin.UseWaitCursor = true;
            cekAkun();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            bool isMail = MainControllClass.isEmail(txtEmail.Text);
            hideWarning(isMail, warningEmail);
        }

        private void txtRepasswird_Leave(object sender, EventArgs e)
        {
            cekPassword(txtPasswordDaftar.Text, txtRepasswordDaftar.Text);
        }

        private void txtPasswordDaftar_Leave(object sender, EventArgs e)
        {
            cekPassword(txtPasswordDaftar.Text, txtRepasswordDaftar.Text);
        }

        private void btnSwapDaftar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnSwapDaftar.Enabled = false;
            btnSwapLogin.Enabled = false;
            btnLogin.Enabled = false;
            txtNama.Focus();
        }

        private void btnSwapLogin_Click(object sender, EventArgs e)
        {
            timer2.Start();
            btnSwapDaftar.Enabled = false;
            btnSwapLogin.Enabled = false;
            btnDaftar.Enabled = false;
            txtUsername.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            swapPanel("1");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            swapPanel("2");
        }

        private void swapPanel(string timer = "1")
        {
            if(timer == "1")
            {
                if (plSlide.Location.X > -519)
                {
                    plSlide.Location = new Point(plSlide.Location.X - 10, plSlide.Location.Y);
                }
                else
                {
                    timer1.Stop();
                    btnSwapDaftar.Enabled = true;
                    btnSwapLogin.Enabled = true;
                    btnDaftar.Enabled = true;
                }
            }
            else
            {
                if (plSlide.Location.X < 0)
                {
                    plSlide.Location = new Point(plSlide.Location.X + 10, plSlide.Location.Y);
                }
                else
                {
                    timer2.Stop();
                    btnSwapDaftar.Enabled = true;
                    btnSwapLogin.Enabled = true;
                    btnLogin.Enabled = true;
                }
            }
        }


        private void btnDaftar_Click(object sender, EventArgs e)
        {
            btnDaftar.Enabled = false;
            btnDaftar.UseWaitCursor = true;
            cekFormDaftar();
        }

        private void txtNoHp_Leave(object sender, EventArgs e)
        {
            if(txtNoHp.Text != string.Empty)
            {
                bool isNohp = MainControllClass.isNumber(txtNoHp.Text);
                hideWarning(isNohp, warningNoHP);
            }
        }
    }
}
