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
    public partial class WorkSchedule : Form
    {
        public WorkSchedule()
        {
            InitializeComponent();
            //nameLabel.Text = StaffLogin.EmpNum;
        }


        private void WorkScheduleMainMenuButton_Click(object sender, EventArgs e)
        {
            new StaffMainMenu().Show();
        }
    }
}
