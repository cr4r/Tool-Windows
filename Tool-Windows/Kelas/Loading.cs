using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Windows.Kelas
{
    class Loading
    {
        public BackgroundWorker worker;
        
        public async void WaitSome(int tunggu)
        {
            await Task.Delay(tunggu);
        }

        public void perulangan(int itu,bool ulang = false,BackgroundWorker worker = null, ProgressBar progressBar = null)
        {
            if (ulang)
            {
                for(int i= progressBar.Value; i < itu+progressBar.Value; i++)
                {
                    worker.ReportProgress(i);
                }
            }
            else
            {
                for(int i = 0; i < itu; i++)
                {
                    worker.ReportProgress(i);
                }
            }
        }

        public Loading(ProgressBar progressBar = null)
        {
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            
            if (progressBar != null)
            {
                worker.ProgressChanged += (obj, ea) =>
                {
                    progressBar.Value = ea.ProgressPercentage;
                };
            }

            /*worker.RunWorkerCompleted += Worker_RunWorkerCompleted;*/
        }

        void Worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                /*lblStatus.Text = "Process was cancelled";*/
            }
            else if (e.Error != null)
            {
                /*lblStatus.Text = "There was an error running the process. The thread aborted";*/
            }
            else
            {
                /*lblStatus.Text = "Process was completed";*/
            }
        }
    }
}
