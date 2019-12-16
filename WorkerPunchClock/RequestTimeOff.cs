using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WorkerPunchClock
{
    public partial class RequestTimeOff : Form
    {
        WorkersDataSet db = new WorkersDataSet();
        string dbConnection;
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
            dbConnection = ConfigurationManager.ConnectionStrings["WorkerPunchClock.Properties.Settings.WorkersConnectionString"].ConnectionString;
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(dbConnection))
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

        private void StartTimeOff_ValueChanged(object sender, EventArgs e)
        {
            EndTimeOff.Value = StartTimeOff.Value;
        }

        private void Request_Click(object sender, EventArgs e)
        {
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(dbConnection))
            using (SqlDataAdapter employeePin = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {login.pin}", myConnection))
            {
                DataTable userPin = new DataTable();

                myConnection.Open();
                employeePin.Fill(userPin);
                myConnection.Close();

                for (int i = 0; i < userPin.Rows.Count; i++)
                {
                    int employeeID = (int)userPin.Rows[i]["EmployeeID"];
                    var startDate = StartTimeOff.Value.Date;
                    var endDate = EndTimeOff.Value.Date;
                    var status = "false";

                    string insert = "INSERT into RequestTimeOff (EmployeeID, StartDate, EndDate, Status) " + "VALUES ("+ employeeID + ", '" + startDate + "', '" + endDate + "', '" + status + "')";
                    dbConnection = ConfigurationManager.ConnectionStrings["WorkerPunchClock.Properties.Settings.WorkersConnectionString"].ConnectionString;

                    var Days = (endDate - startDate).TotalDays;

                    MessageBox.Show("You have requested " + Days + " days off");


                    using (SqlCommand s = new SqlCommand(insert))
                    {
                        s.Connection = myConnection;
                        myConnection.Open();
                        s.ExecuteNonQuery();
                        myConnection.Close();
                    }
                }

               

            }
        }
    }
}
