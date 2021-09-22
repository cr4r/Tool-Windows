using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Windows.tools.VPN
{
    public partial class NordVPN : UserControl
    {
        List<string> akunDataNord = new List<string>();
        private readonly Random _random = new Random();
        Home home = new Home();
        string gagalAmbilData = "Gagal mengambil data\nMungkin anda tidak terhubung ke internet\n\nCobalah Tekan Tombol Refresh";
        string baseUrl = "https://raw.githubusercontent.com/cr4r/ceknord/main/akun";
        int hitung = 0;

        public NordVPN()
        {
            InitializeComponent();
        }

        private int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void clear()
        {
            lblRefresh.Enabled = false;
            akunDataNord.Clear();
            getAkunNord();
            matiSemua("Tidak ada", true);
            Thread.Sleep(5* 1000);
            lblRefresh.Enabled = true;
        }

        private void matiSemua(string kata = "Tidak ada", bool tombol = false)
        {
            lblEmail.Text = kata;
            lblPassword.Text = kata;
            lblExpired.Text = kata;
            btnGenerate.Enabled = tombol;
        }

        private void munculData()
        {
            int value;
            btnGenerate.Enabled = false;
            char[] pemisah = { ':', ' ' };
            string[] hasil = akunDataNord[RandomNumber(0, akunDataNord.Count)].Trim().Split(pemisah);
            lblEmail.Text = hasil[0];
            lblPassword.Text = hasil[1];
            if (hasil.Length > 2)
            {
                if (int.TryParse(hasil[2].Substring(0, 2), out value))
                {
                    lblExpired.Text = hasil[2];
                }
            }
            toolTip1.RemoveAll();
            btnGenerate.Enabled = true;
        }

        private async void getAkunNord()
        {
            var loadingHome = home.loadingHome;
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
                                for(int i = 0; i < anu.Length; i++)
                                {
                                    loadingHome.Value = (i / anu.Length) * 100;
                                    akunDataNord.Add(anu[i]);
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
            catch (Exception e)
            {
                MessageBox.Show($"{gagalAmbilData}\n{e}\n{hitung}\n{loadingHome.Value}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            matiSemua("Silahkan Tunggu ...");
            
            if (akunDataNord.Count > 1)
            {
                munculData();
            }
            else
            {
                MessageBox.Show(gagalAmbilData, "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnGenerate.UseWaitCursor = false;
        }

        private void lblRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalin_Click(object sender, EventArgs e)
        {
            if (lblEmail.Text.Trim().ToLower() != "tidak ada")
            {
                string dataSalin = lblEmail.Text.Trim() + ":" + lblPassword.Text.Trim();
                Clipboard.SetText(dataSalin);

                toolTip1.SetToolTip(btnSalin, dataSalin + "\nTelah Disalin");
            }
            else
            {
                toolTip1.SetToolTip(btnSalin, "Data belum ada");
            }
        }

        private void NordVPN_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void lblRefresh_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lblRefresh, "Untuk memulai ulang jika internet sudah terhubung");
        }

        private void lblRefresh_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear();
        }
    }
}
