using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Windows.tools
{
    public partial class nordVPN : Form
    {
        public nordVPN()
        {
            InitializeComponent();
        }
        private readonly Random _random = new Random();
        private int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void clear()
        {
            btnGenerate.Enabled = true;
            lblEmail.Text = "Tidak ada";
            lblPassword.Text = lblEmail.Text;
            lblExpired.Text = lblEmail.Text;
            getAkunNord();
        }

        List<string> akunDataNord = new List<string>();
        private async void getAkunNord()
        {
            akunDataNord.Clear();
            string baseUrl = "https://raw.githubusercontent.com/cr4r/ceknord/main/akun";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                string[] anu = data.Split('\n');
                                foreach (string anu1 in anu)
                                {
                                    akunDataNord.Add(anu1);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Gagal!\nMungkin koneksi internet anda terputus atau terlalu banyak request", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnGenerate.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch
            {
                lblEmail.Text = "Tidak ada";
                lblPassword.Text = lblEmail.Text.ToString();
                MessageBox.Show("Mungkin koneksi internet anda terputus\n\nTool ini membutuhkan koneksi internet", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGenerate.Enabled = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblEmail.Text = "Silahkan Tunggu ...";
            btnGenerate.UseWaitCursor = true;
            lblPassword.Text = lblEmail.Text.ToString();
            btnGenerate.Enabled = false;

            if (akunDataNord.Count > 1)
            {
                char[] pemisah = { ':', ' ' };
                string[] hasil = akunDataNord[RandomNumber(0, akunDataNord.Count)].Trim().Split(pemisah);
                lblEmail.Text = hasil[0];
                lblPassword.Text = hasil[1];
                if (hasil.Length > 2)
                {
                    int value;
                    if (int.TryParse(hasil[2].Substring(0, 2), out value))
                    {
                        lblExpired.Text = hasil[2];
                    }
                }
                toolTip1.RemoveAll();
                btnGenerate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Gagal mengambil data\nMungkin anda tidak terhubung ke internet\n\nCobalah Tekan Tombol Refresh", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnGenerate.UseWaitCursor = false;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear();
        }

        private void nordVPN_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSalin_Click(object sender, EventArgs e)
        {
            if(lblEmail.Text.Trim().ToLower() != "tidak ada")
            {
                string dataSalin = lblEmail.Text.Trim() + ":" + lblPassword.Text.Trim();
                Clipboard.SetText(dataSalin);

                toolTip1.SetToolTip(btnSalin, dataSalin + "\nTelah Disalin");
            }else
            {
                toolTip1.SetToolTip(btnSalin, "Data belum ada");
            }
        }

        private void lblRefresh_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lblRefresh, "Untuk memulai ulang jika internet sudah terhubung");
        }
    }
}
