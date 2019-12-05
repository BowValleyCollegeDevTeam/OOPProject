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
    public partial class StaffMainMenu : Form
    {
        public StaffMainMenu()
        {
            InitializeComponent();
        }

        private void StaffMainMenuClosing(object sender, FormClosingEventArgs e)
        {
            var staffLogin = new StaffLogin();
            Hide();
            staffLogin.Show();
        }

        private void StaffMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void TimeTimerTicker_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
        }

        private void WorkScheduleMouseHover(object sender, EventArgs e)
        {
            WorkScheduleLabel.ForeColor = Color.Red;
        }

        private void WorkScheduleMouseLeave(object sender, EventArgs e)
        {
            WorkScheduleLabel.ForeColor = Color.Black;
        }

        private void WorkSchedulePictureBox_Click(object sender, EventArgs e)
        {
            new WorkSchedule().Show();
        }
        private void ClockInOutMouseHover(object sender, EventArgs e)
        {
            ClockInOutLabel.ForeColor = Color.Red;
        }

        private void ClockInOutMouseLeave(object sender, EventArgs e)
        {
            ClockInOutLabel.ForeColor = Color.Black;
        }

        private void ClockInOutPictureBox_Click(object sender, EventArgs e)
        {
            new ClockInOut().Show();

        }

        private void RequestTimeOffMouseHover(object sender, EventArgs e)
        {
            RequestTimeOffLabel.ForeColor = Color.Red;
        }

        private void RequestTimeOffMouseLeave(object sender, EventArgs e)
        {
            RequestTimeOffLabel.ForeColor = Color.Black;
        }

        private void RequestTimeOffPictureBox_Click(object sender, EventArgs e)
        {
            new RequestTimeOff().Show();
        }

        private void PayStubMouseHover(object sender, EventArgs e)
        {
            PayStubLabel.ForeColor = Color.Red;
        }

        private void PayStubMouseLeave(object sender, EventArgs e)
        {
            PayStubLabel.ForeColor = Color.Black;
        }

        private void PayStubPictureBox_Click(object sender, EventArgs e)
        {
            new PayStub().Show();
        }


        
    }
}
