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
            TimeTimerTicker.Start();
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
            this.TimeLabel.Text = dateTime.ToString();
        }

        private void WorkScheduleMouseEnter(object sender, EventArgs e)
        {
            WorkScheduleLabel.ForeColor = Color.Red;
        }

        private void WorkScheduleMouseLeave(object sender, EventArgs e)
        {
            WorkScheduleLabel.ForeColor = Color.Black;
        }
    }
}
