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
    }
}
