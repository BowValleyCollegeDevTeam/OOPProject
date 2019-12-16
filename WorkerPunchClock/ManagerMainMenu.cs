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
    public partial class ManagerMainMenu : Form
    {
        public ManagerMainMenu()
        {
            InitializeComponent();
        
        }

        private void ManagerMainMenuClosing(object sender, FormClosingEventArgs e)
        {
            var staffLogin = new StaffLogin();
            Hide();
            staffLogin.Show();
        }

        private void ManagerPageTimer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
          
        }

        private void WorkSchedulePictureBox_Click(object sender, EventArgs e)
        {
            new WorkSchedule().Show();
        }

        private void WorkScheduleMouseHover(object sender, EventArgs e)
        {
            WorkScheduleLabel.ForeColor = Color.Red;
        }

        private void WorkScheduleMouseLeave(object sender, EventArgs e)
        {
            WorkScheduleLabel.ForeColor = Color.Black;
        }

        private void ClockInOutPictureBox_Click(object sender, EventArgs e)
        {
            new ClockInOut().Show();
        }

        private void ClockInOutMouseHover(object sender, EventArgs e)
        {
            ClockInOutLabel.ForeColor = Color.Red;
        }

        private void ClockInOutMouseLeave(object sender, EventArgs e)
        {
            ClockInOutLabel.ForeColor = Color.Black;
        }

        private void RequestTimeOffPictureBox_Click(object sender, EventArgs e)
        {
            new RequestTimeOff().Show();
        }

        private void RequestTimeOffMouseHover(object sender, EventArgs e)
        {
            RequestTimeOffLabel.ForeColor = Color.Red;
        }

        private void RequestTimeOffMouseLeave(object sender, EventArgs e)
        {
            RequestTimeOffLabel.ForeColor = Color.Black;
        }

        private void PayStubPictureBox_Click(object sender, EventArgs e)
        {
            new PayStub().Show();
        }

        private void PayStubMouseHover(object sender, EventArgs e)
        {
            PayStubLabel.ForeColor = Color.Red;
        }

        private void PayStubMouseLeave(object sender, EventArgs e)
        {
            PayStubLabel.ForeColor = Color.Black;
        }

        private void CreateEditSchedulePictureBox_Click(object sender, EventArgs e)
        {
            new CreateEditSchedule().Show();
        }

        private void CreateEditScheduleMouseHover(object sender, EventArgs e)
        {
            CreateEditScheduleLabel.ForeColor = Color.Red;
        }

        private void CreateEditScheduleMouseLeave(object sender, EventArgs e)
        {
            CreateEditScheduleLabel.ForeColor = Color.Black;
        }

        private void CreateEditEmployeePictureBox_Click(object sender, EventArgs e)
        {
            new CreateEditEmployee().Show();
        }

        private void CreateEditEmployeeMouseHover(object sender, EventArgs e)
        {
            CreateEditEmployeeLabel.ForeColor = Color.Red;
        }

        private void CreateEditEmployeeMouseLeave(object sender, EventArgs e)
        {
            CreateEditEmployeeLabel.ForeColor = Color.Black;
        }

        private void ApprovePayStubsPictureBox_Click(object sender, EventArgs e)
        {
            new ApprovePayStubs().Show();
        }

        private void ApprovePayStubsMouseHover(object sender, EventArgs e)
        {
            ApprovePayStubsLabel.ForeColor = Color.Red;
        }

        private void ApprovePayStubsMouseLeave(object sender, EventArgs e)
        {
            ApprovePayStubsLabel.ForeColor = Color.Black;
        }

        private void ApproveDenyTimeOffPictureBox_Click(object sender, EventArgs e)
        {
            new ApproveDenyTimeOff().Show();
        }

        private void ApproveDenyTimeOffMouseHover(object sender, EventArgs e)
        {
            ApproveDenyTimeOffLabel.ForeColor = Color.Red;
        }

        private void ApproveDenyTimeOffMouseLeave(object sender, EventArgs e)
        {
            ApproveDenyTimeOffLabel.ForeColor = Color.Black;
        }
        //public void getPin(string p)
        //{
        //    using (StaffLogin login = new StaffLogin())
        //    {
        //        p = login.pin;
        //    }


        //}
        private void ManagerMainMenu_Load(object sender, EventArgs e)
        {
            TopInfoBar managerInfo = new TopInfoBar();
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kara\Source\Repos\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";
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
                    this.topInfoBar1.StaffNameLabel.Text = "Name: " + FirstName + " " + LastName;

                }
                
            }

        }
    }
}
