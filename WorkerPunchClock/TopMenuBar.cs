using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkerPunchClock
{
    public partial class TopMenuBar : UserControl
    {
        public TopMenuBar()
        {
            InitializeComponent();
            TimeTimerTicker.Start();
        }

        private void TimeTimerTicker_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.TimeLabel.Text = dateTime.ToString();
           
        }

        private void TopMenuPanel_Paint(object sender, PaintEventArgs e)
        {
            WorkerStatusClass workerStatus = new WorkerStatusClass();
            workerStatus.Status = "Clocked Out";
            StatusLabel.Text = "Status: " + workerStatus.Status;
        }

        private void StatusLabel_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
