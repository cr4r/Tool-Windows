using System;
using System.Windows.Forms;
using Tool_Windows.Kelas;
using Guna.UI2.WinForms;
using Tool_Windows.tools.AndroidTool;
using Tool_Windows.tools.VPN;
using System.IO;
using Tool_Windows.Database;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections;
using System.Globalization;

namespace Tool_Windows
{
    public partial class Home : Form
    {
        Loading loading = new Loading();
        FileClass fileClass = new FileClass();
        DateTime utc;

        /*Initial untuk DB*/
        string letakDB = Path.GetFullPath("data")+@"\sesi.json";
        private bool login = false;
        private string userLogin, passwordLogin, dbSementara;
        public List<string> SubMenu;
        private Dictionary<string, bool> sesiSubMenu;
        private IDictionary dbDict;

        /*KUMPULAN TOOL DARI SUBMENU*/
        NordVPN nordVpn;
        Info info;
        FastBoot fastBoot;
        ADB adb;

        private void setupDB()
        {
            Preferensi preferensi = new Preferensi()
            {
                SubMenu = SubMenu,
                login = login,
                passwordLogin = passwordLogin,
                userLogin = userLogin,
                sesiSubMenu = sesiSubMenu
            };

            string preferensiStr = JsonConvert.SerializeObject(preferensi);

            /*Cek File db untuk sesi*/
            dbSementara = fileClass.bacaFile(letakDB);

            if (dbSementara == string.Empty)
            {
                /*Jika file db sesi tidak ada maka buat folder dan file */
                fileClass.buatFile(letakDB, preferensiStr);
            }
            else
            {
                dbDict = JsonConvert.DeserializeObject<IDictionary>(dbSementara);
            }
        }

        private void setWaktu()
        {
            utc = DateTime.Now;
            lblWaktu.Text = utc.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
        }

        public Home()
        {
            InitializeComponent();

            setWaktu();

            userLogin = "cr4r";
            passwordLogin = "123";
            SubMenu = new List<string>()
            {
                "VPN",
                "AndroidTool",
                "CoomingSoon"
            };
            sesiSubMenu = new Dictionary<string, bool>
            {
                { "vpn", false}
            };

            customSubMenu();
            workerSubMenu();
            setupDB();

            /*MessageBox.Show(fileClass.convertDictToStr(dbDict));*/
        }

        private void customSubMenu()
        {
            plAndroidToolSubMenu.Visible = false;
            plVPNSubMenu.Visible = false;
            plCommingSoonSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            plAndroidToolSubMenu.Visible = false;
            plVPNSubMenu.Visible = false;
            plCommingSoonSubMenu.Visible = false;
        }

        private void showSubMenu(Guna2Panel subMenu = null, Guna2Button button = null)
        {
            if (button != null)
            {
                button.Enabled = false;
            }

            if (subMenu.Visible)
            {
                subMenu.Visible = false;
            }
            else
            {
                hideSubMenu();
                subMenu.Visible = true;
            }

            if (button != null)
            {
                button.Enabled = true;
            }
        }

        private void workerSubMenu()
        {
            var worker = loading.worker;
            worker.ProgressChanged += (obj, ea) =>
            {
                loadingHome.Value = ea.ProgressPercentage;
                if (loadingHome.Value == 100)
                {
                    loadingHome.Value = 0;
                }
            };

            worker.DoWork += (obj, ea) =>
            {
                int hitung = 0;
                while (hitung < 100)
                {
                    worker.ReportProgress(hitung);
                    hitung++;
                }
            };

        }

        private void clear()
        {
            /*toolTip.SetToolTip(btnLogout, "Logout");
            toolTip.SetToolTip(btnSettings, "Pengaturan");
            toolTip.SetToolTip(lblNamaAkun, lblNamaAkun.Text.ToString());
            toolTip.SetToolTip(lblRole, lblRole.Text.ToString());*/

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnVPN_Click(object sender, EventArgs e)
        {
            loading.worker.RunWorkerAsync();
            showSubMenu(plVPNSubMenu, btnVPN);
        }

        private void btnAndroidTool_Click(object sender, EventArgs e)
        {
            loading.worker.RunWorkerAsync();
            showSubMenu(plAndroidToolSubMenu, btnAndroidTool);
        }

        private void lblInfoHome_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(DateTime.Now.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            loading.worker.RunWorkerAsync();
            info.Show();
        }

        private void btnVPN_MouseHover(object sender, EventArgs e)
        {
            if (plVPNSubMenu.Visible == false)
            {
                loading.worker.RunWorkerAsync();
                showSubMenu(plVPNSubMenu, btnVPN);
            }
        }

        private void btnAndroidTool_MouseHover(object sender, EventArgs e)
        {
            if (plAndroidToolSubMenu.Visible == false)
            {
                loading.worker.RunWorkerAsync();
                showSubMenu(plAndroidToolSubMenu,btnAndroidTool);
            }
        }

        private void btnCommingSoon_MouseHover(object sender, EventArgs e)
        {
            if (plCommingSoonSubMenu.Visible == false)
            {
                loading.worker.RunWorkerAsync();
                showSubMenu(plCommingSoonSubMenu, btnCommingSoon);
            }
        }

        private void btnCommingSoon_Click(object sender, EventArgs e)
        {
            loading.worker.RunWorkerAsync();
            showSubMenu(plCommingSoonSubMenu, btnCommingSoon);
        }

        private void btnNordVPN_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["NordVPN"];
            if (fc == null)
            {
                nordVpn = new NordVPN();
                MainControllClass.showControl(nordVpn, plIsi);
            }
            else
            {
                nordVpn.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setWaktu();
            timer1.Start();
        }

        private void btnFastBoot_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FastBoot"];
            if (fc == null)
            {
                fastBoot = new FastBoot();
                MainControllClass.showControl(fastBoot, plIsi);
            }
            else
            {
                fastBoot.Show();
            }
        }

        private void btnADBTool_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ADB"];
            if (fc == null)
            {
                adb = new ADB();
                MainControllClass.showControl(adb, plIsi);
            }
            else
            {
                adb.Show();
            }
        }
    }
}
