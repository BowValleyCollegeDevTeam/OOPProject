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
    public partial class RequestTimeOff : Form
    {
        public RequestTimeOff()
        {
            InitializeComponent();
        }

        private void RequestTimeOffMainMenuButton_Click(object sender, EventArgs e)
        {
            new StaffMainMenu().Show();
        }

        private void RequestTimeOff_Load(object sender, EventArgs e)
        {

        }

        private void StartTimeOff_ValueChanged(object sender, EventArgs e)
        {
            EndTimeOff.Value = StartTimeOff.Value;
        }

        private void Request_Click(object sender, EventArgs e)
        {
            var Date1 = StartTimeOff.Value.Date;
            var Date2 = EndTimeOff.Value.Date;

            var Days = (Date2 - Date1).TotalDays;
            
            MessageBox.Show("You have requested " + Days + " days off");
        }
    }
}
