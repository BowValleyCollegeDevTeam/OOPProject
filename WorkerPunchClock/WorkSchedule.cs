using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkerPunchClock
{
    public partial class WorkSchedule : Form
    {
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ajdon\Documents\GitHub\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security = True";

        public WorkSchedule()
        {
            InitializeComponent();

        }


        private void WorkScheduleMainMenuButton_Click(object sender, EventArgs e)
        {
            new StaffMainMenu().Show();
        }

        private void WorkSchedule_Load(object sender, EventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(str))
            {
                int employeeID = 0;
                using (StaffLogin login = new StaffLogin())
                using (SqlDataAdapter employeePin = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {login.pin}", myConnection))
                {
                    DataTable userPin = new DataTable();

                    myConnection.Open();
                    employeePin.Fill(userPin);
                    myConnection.Close();
                    for (int row = 0; row < userPin.Rows.Count; row++)
                    {
                        employeeID = (int)userPin.Rows[row]["EmployeeID"];
                        string FirstName = (string)userPin.Rows[row]["FName"];
                        string LastName = (string)userPin.Rows[row]["LName"];
                        this.topInfoBar1.StaffNameLabel.Text = "Name: " + FirstName + " " + LastName;
                        nameLabel.Text = FirstName + " " + LastName;
                    }
                }
                using (SqlDataAdapter clientPayStubAdapter = new SqlDataAdapter($"SELECT * FROM Schedule WHERE EmployeeID = {employeeID}", myConnection))
                {
                    DataTable clientPayStub = new DataTable();

                    myConnection.Open();
                    clientPayStubAdapter.Fill(clientPayStub);
                    myConnection.Close();
                    for (int row = 0; row < clientPayStub.Rows.Count; row++)
                    {
                        DateTime startDateTime = (DateTime)clientPayStub.Rows[row]["StartDateTime"];
                        DateTime endDateTime = (DateTime)clientPayStub.Rows[row]["EndDateTime"];

                        scheduleListBox.Items.Add($"Start: {startDateTime,-20} End: {endDateTime,-20}");
                    }
                }
            }
        }
    }
}