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
    public partial class ClockInOut : Form
    {
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\coleb\Source\Repos\BowValleyCollegeDevTeam\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";
        public ClockInOut()
        {
            InitializeComponent();
        }

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
                        ClockInButton.Text = "Clock In";
                    }
                    else if (Status == true)
                    {
                        this.topInfoBar1.StatusLabel.Text = "Status: " + "Clocked In";
                        ClockInButton.Text = "Clock Out";
                    }

                }
            }
        }

        private void ClockInOut_Load(object sender, EventArgs e)
        { 
            CheckStatus();
        }

        private void ClockInButton_Click(object sender, EventArgs e)
        {

           
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(str))
            using (SqlDataAdapter ClockAdapter = new SqlDataAdapter($"SELECT * FROM ClockInClockOut", myConnection))
            using (SqlDataAdapter employeePin = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {login.pin}", myConnection))
            {
                DataTable userPin = new DataTable();

                myConnection.Open();
                employeePin.Fill(userPin);
                for (int row = 0; row < userPin.Rows.Count; row++)
                {
                    int EmployeeId = (int)userPin.Rows[row]["EmployeeId"];
                    bool Status = (bool)userPin.Rows[row]["Status"];

                    if (Status == false)
                    {
                        DateTime Clock = DateTime.Now;
                        DateTime Date = DateTime.Today;

                        Label ClockIn = new Label();
                        ClockIn.AutoSize = true;
                        ClockIn.Dock = DockStyle.Top;
                        ClockIn.Text = "Clock In At: " + Clock.ToString("MM/dd/yyyy" + " " + "HH:mm:ss");
                        ClockInOutPanel.Controls.Add(ClockIn);

                        SqlCommand InsertClockinData = new SqlCommand("insert into ClockInClockOut (EmployeeID, StartTime, EndTime, Date) values ('" + EmployeeId + "', '" + Clock + "', '"+Clock.AddHours(8)+"', '" + Date + "');", myConnection);
                        SqlCommand UpdateEmployeeStatus = new SqlCommand("update Employees Set Status = '" + 1 + "' WHERE EmployeeID = '"+EmployeeId+"' ", myConnection);
                        InsertClockinData.ExecuteNonQuery();
                        UpdateEmployeeStatus.ExecuteNonQuery();
                        myConnection.Close();
                        CheckStatus();
                    }

                    else if (Status == true)
                    {

                        DateTime Clock = DateTime.Now;
                        DateTime Date = DateTime.Today;

                        Label ClockOut = new Label();
                        ClockOut.AutoSize = true;
                        ClockOut.Dock = DockStyle.Top;
                        ClockOut.Text = "Clock Out At: " + Clock.ToString("MM/dd/yyyy" + " " + "HH:mm:ss");
                        ClockInOutPanel.Controls.Add(ClockOut);

                        SqlCommand UpdateEndTime = new SqlCommand("update ClockInClockOut Set EndTime = '" + Clock + "' WHERE EmployeeID = '"+EmployeeId+"' AND Date = '"+Date+"' ", myConnection);
                        SqlCommand UpdateEmployeeStatus = new SqlCommand("update Employees Set Status = '" + 0 + "' WHERE EmployeeID = '"+EmployeeId+"' ", myConnection);
                        UpdateEndTime.ExecuteNonQuery();
                        UpdateEmployeeStatus.ExecuteNonQuery();
                        CheckStatus();


                    }



                }

            }
            }

        private void ClockInOutClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ClockInOutClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
