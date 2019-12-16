using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkerPunchClock
{
    public partial class ClockInOut : Form
    {
        public ClockInOut()
        {
            InitializeComponent();
        }

        private void ClockInOutMainMenuButton_Click(object sender, EventArgs e)
        {
            new StaffMainMenu().Show();
        }

        private void ClockInOut_Load(object sender, EventArgs e)
        {
            //
            //To Do 
            //
            // If Employee Status is Clocked In Change ClockInOutButton.Text = "Clock Out

        }

        private void ClockInOutButton_Click(object sender, EventArgs e)
        {
            //WorkerStatusClass workerStatus = new WorkerStatusClass();
            //workerStatus.Status = "Clocked In";

            DateTime punchInOut = DateTime.Now;
            string ClockFormat = "MM/dd/yyyy HH:mm:ss";

            Label punchInOutLabel = new Label();
            punchInOutLabel.AutoSize = true;
            punchInOutLabel.Font = new Font("Microsoft Sans Serif", 16);
            punchInOutLabel.Dock = DockStyle.Top;

            Label Status = new Label();
            Status.Text = "Clocked In At: ";
            Status.Font = new Font("Microsoft Sans Serif", 16);
            Status.Dock = DockStyle.Top;
            
            punchInOutLabel.Text = Status.Text + punchInOut.ToString(ClockFormat);
            ClockInOutPanel.Controls.Add(punchInOutLabel);
        }
    }
}
