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
    public partial class ApproveDenyTimeOff : Form
    {
        public ApproveDenyTimeOff()
        {
            InitializeComponent();
        }

        private void EmployeeNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// TO DO
            /// This should display the employee names
            /// depending on the employee name it should
            /// change what gets displayed in the timeoff panel
        }

        private void ApproveTimeOffButton_Click(object sender, EventArgs e)
        {
            ///To do 
            ///once button clicks the dates shown should be blocked off 
            ///on schedule
        }

        private void DenyTimeOffButton_Click(object sender, EventArgs e)
        {
            ///to do
            /// not sure???
        }
    }
}
