using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Windows.tools.AndroidTool.Help
{
    public partial class HelpToolADB : Form
    {
        public HelpToolADB()
        {
            InitializeComponent();
            clear();
        }

        void clear()
        {
            rtbInstallAPK.Text = @"Install APk melalui adb
Yang akan menginstall apk yang dituju secara otomatis";

            rtbBackup.Text = @"Mem";

            rtbAdbWireles.Text = @"Tutorial untuk pertama kali:
- Hubungkan android anda ke pc melalui kabel
- Izinkan fingerprint (jika pertama kali menggunakan adb)
- Ketik IP dari devices anda yang terhubung dalam satu jaringan
- Lalu Klik tombol hubungkan IP
- Jika benar akan muncul ""Connected to IPDevices:5555""
- Jika sudah maka, jika ingin menyambungkan kembali tinggal menginput IP devices tanpa harus menggunakan USB lagi";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
