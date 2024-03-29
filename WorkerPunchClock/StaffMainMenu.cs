﻿using System;
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
        // Connection string for database
        //NOTE: This string has to be used for each user running the code.
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\coleb\Source\Repos\BowValleyCollegeDevTeam\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";
        public StaffMainMenu()
        {
            InitializeComponent();
            
            
        }

        //When this form is closed it will open the Staff Login Form again.
        private void StaffMainMenuClosing(object sender, FormClosingEventArgs e)
        {
            var staffLogin = new StaffLogin();
            staffLogin.Show();
        }

        //This checks the status of the Employee from the database.
        //Sets the top menu bar values equal to the values in the database for the employee.
        public void CheckStatus()
        {
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(str))
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
                    bool Status = (bool)userPin.Rows[row]["Status"];

                    this.topInfoBar1.StaffNameLabel.Text = "Name: " + FirstName + " " + LastName;
                    if (Status == false)
                    {
                        this.topInfoBar1.StatusLabel.Text = "Status: " + "Clocked Out";
                        
                    }
                    else if (Status == true)
                    {
                        this.topInfoBar1.StatusLabel.Text = "Status: " + "Clocked In";
                        
                    }

                }
            }
        }

        private void StaffMainMenu_Load(object sender, EventArgs e)
        {

            CheckStatus();
           
        }

      
        // These functions change the fore color of labels when the mouse hovers over them.
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

        private void StaffMainMenuEnter(object sender, EventArgs e)
        {
           
        }

        private void StaffMainMenuClick(object sender, EventArgs e)
        {

        }

        private void StaffMainMenuMouseEnter(object sender, EventArgs e)
        {
            CheckStatus();
        }
    }
}
