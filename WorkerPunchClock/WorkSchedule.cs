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
        //String must be changed depending on machine.
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\coleb\Source\Repos\BowValleyCollegeDevTeam\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";

        //This function checks if the user is clocked in, or clocked out and pushes it to the top status bar.
        public void CheckStatus()
        {
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(str))
            using (SqlDataAdapter employeePin = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {login.pin}", myConnection))
            {
                DataTable userPin = new DataTable();

                //Fills data table
                myConnection.Open();
                employeePin.Fill(userPin);
                myConnection.Close();
                //populates top status bar
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

        public WorkSchedule()
        {
            InitializeComponent();
        }


        private void WorkSchedule_Load(object sender, EventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(str))
            {
                CheckStatus();
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

                //Checks employee id to make sure only the employee who is currently signed in can view their pay stubs
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

                        //pushing pay stubs to list box
                        scheduleListBox.Items.Add($"Start: {startDateTime,-20} End: {endDateTime,-20}");
                    }
                }
            }
        }
    }
}