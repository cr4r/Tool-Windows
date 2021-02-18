using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Windows
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnNordVPN_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            tools.nordVPN nordVPN = new tools.nordVPN();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Text == "Nord VPN")
                {
                    IsOpen = true;
                    nordVPN.Show();
                    break;
                }
            }
            if(IsOpen == false)
            {
                nordVPN.ShowDialog();
            }
        }
    }
}
