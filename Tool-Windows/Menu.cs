using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tool_Windows
{
    public partial class Menu : Form
    {
        int mov, movX, movY;
        bool openForm, IsOpen = false;
        tools.nordVPN nordVPN = new tools.nordVPN();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            /*Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));*/
        }

        private void clear()
        {
            
        }

        void toggle(object sender)
        {
            btnNordVPN.ForeColor = System.Drawing.Color.Aquamarine;
        }

        private void btnNordVPN_Click(object sender, EventArgs e)
        {
            /*toggle(sender);*/
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text.ToString().ToLower() == "nord vpn")
                {
                    IsOpen = false;
                    openForm = true;
                    break;
                }
            }

            if (IsOpen == false && openForm == false)
            {
                plIsi.Controls.Clear();
                nordVPN.TopLevel = false;
                plIsi.Controls.Add(nordVPN);
                nordVPN.Dock = DockStyle.Fill;
                nordVPN.Show();
            }
            else if(IsOpen == false && openForm == true)
            {
                nordVPN.Visible = true;
                IsOpen = true;
            }
            else
            {
                nordVPN.Visible = false;
                IsOpen = false;
            }
            MessageBox.Show("Isopen: "+IsOpen.ToString() + "\nOpen Form:" + openForm.ToString(), "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void plGambarAtas_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1; movX = e.X; movY = e.Y;
        }

        private void plGambarAtas_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void plGambarAtas_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            if (this.WindowState.ToString().ToLower() == "normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition= FormStartPosition.CenterScreen;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
        }

        private void btnNordVPN_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = System.Drawing.Color.Aquamarine;
        }
    }
}
