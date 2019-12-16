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
    public partial class PayStub : Form
    {
        public PayStub()
        {
            InitializeComponent();
        }

        private void PayStubMainMenuButton_Click(object sender, EventArgs e)
        {
            new StaffMainMenu().Show();
        }

        private void payStubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PayStub_Load(object sender, EventArgs e)
        {
            
            //payStubComboBox.Items.Add();
        }
    }
}
