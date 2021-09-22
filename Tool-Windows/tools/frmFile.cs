using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool_Windows.Kelas;

namespace Tool_Windows.tools
{
    public partial class frmFile : Form
    {
        /*BACKUP*/
        Loading loading = new Loading();
        FileClass fileClass = new FileClass();

        public frmFile()
        {
            InitializeComponent();

            var worker = loading.worker;
            worker.ProgressChanged += (obj, ea) =>
            {
                guna2ProgressBar1.Value = ea.ProgressPercentage;
                lblPersen.Text = guna2ProgressBar1.Value.ToString() + "%";
                if(guna2ProgressBar1.Value == 100)
                {
                    guna2ProgressBar1.Value = 0;
                }
            };


            worker.DoWork += (obj, ea) =>
            {
                for(int i = 0; i < lstFile.Items.Count; i++)
                {
                    string namaFile = lstFile.Items[i].ToString();
                    fileClass.copy(namaFile, txtTarget.Text + "\\" + Path.GetFileName(namaFile), worker);
                }
            };
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            fileClass.dialogOpenFile("Semua | *.*", true, null, lstFile);
        }

        private void btnBrowseTarget_Click(object sender, EventArgs e)
        {
            fileClass.dialogOpenFolder(txtTarget);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            loading.worker.RunWorkerAsync();
        }
    }
}
