using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WorkerPunchClock
{
    public partial class StaffMainMenu : Form
    {
        private string dbConnectionString;
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
            dbConnectionString = ConfigurationManager.ConnectionStrings["WorkerPunchClock.Properties.Settings.WorkersConnectionString"].ConnectionString;
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(dbConnectionString))
            using (SqlDataAdapter employeePin = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {login.pin}", myConnection))
            {
                DataTable userPin = new DataTable();

                myConnection.Open();
                employeePin.Fill(userPin);
                myConnection.Close();
                for (int row = 0; row < userPin.Rows.Count; row++)
                {
                    string FirstName = (string)userPin.Rows[row]["FName"];
                    string LastName = (string)userPin.Rows[row]["LName"];
                    this.topInfoBar1.StaffNameLabel.Text = "Name: " + FirstName + " " + LastName;
                    
                }



            }
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
