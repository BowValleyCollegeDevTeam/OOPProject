using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WorkerPunchClock
{
    public partial class ApproveDenyTimeOff : Form
    {
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\coleb\Source\Repos\BowValleyCollegeDevTeam\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";
        public ApproveDenyTimeOff()
        {
            InitializeComponent();
            EmployeeName();
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

                    }
                    else if (Status == true)
                    {
                        this.topInfoBar1.StatusLabel.Text = "Status: " + "Clocked In";

                    }

                }
            }
        }
        private void EmployeeName()
        {
            using (SqlConnection myconnection = new SqlConnection(str))
            using (SqlDataAdapter emp = new SqlDataAdapter($"SELECT * FROM Employees", myconnection))
            {
                DataTable getEmp = new DataTable();

                myconnection.Open();
                emp.Fill(getEmp);
                myconnection.Close();

                for (int row = 0; row < getEmp.Rows.Count; row++)
                {
                    string FirstName = (string)getEmp.Rows[row]["FName"];
                    string LastName = (string)getEmp.Rows[row]["LName"];
                    this.EmployeeNameComboBox.Items.Add(FirstName +" "+ LastName);
                }
            };
        }
        private void RequestedTimeOff()
        {
            string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];

            using (SqlConnection myconnection = new SqlConnection(str))
            using (SqlDataAdapter Time = new SqlDataAdapter($"SELECT * FROM RequestTimeOff JOIN Employees ON RequestTimeOff.EmployeeID = Employees.EmployeeId WHERE FName = '{emFName}' AND LName = '{emLName}'", myconnection))
            {
                DataTable getTime = new DataTable();

                myconnection.Open();
                Time.Fill(getTime);
                myconnection.Close();

                for (int row = 0; row < getTime.Rows.Count; row++)
                {
                    DateTime sd = (DateTime)getTime.Rows[row]["StartDate"];
                    DateTime ed = (DateTime)getTime.Rows[row]["EndDate"];
                    var totaldays = ((TimeSpan)(ed - sd)).Days;
                    RequestedTimeListBox.Items.Add(totaldays + " Days Off"  + $"   Start Date: {sd}    End Date: {ed}");
                }
            };
        }
        private void EmployeeNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestedTimeOff();
            
            /// TO DO
            /// This should display the employee names
            /// depending on the employee name it should
            /// change what gets displayed in the timeoff panel
        }

        private void ApproveTimeOff()
        {
            string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];

            using (SqlConnection myconnection = new SqlConnection(str))
            using (SqlDataAdapter approve = new SqlDataAdapter($"SELECT * FROM RequestTimeOff JOIN Employees ON RequestTimeOff.EmployeeID = Employees.EmployeeId WHERE FName = '{emFName}' AND LName = '{emLName}'", myconnection))
            {
                DataTable a = new DataTable();

                myconnection.Open();
                approve.Fill(a);
                


                for (int row = 0; row < a.Rows.Count; row++)
                {
                    int employeeid = (int)a.Rows[row]["EmployeeID"];
                    SqlCommand RequestApproved = new SqlCommand($"update RequestTimeOff Set Status = 'Approved' " +
                        "WHERE EmployeeID = "+employeeid+"", myconnection);
                    RequestApproved.ExecuteNonQuery();
                }
                myconnection.Close();
            };
        }
        private void ApproveTimeOffButton_Click(object sender, EventArgs e)
        {
            ApproveTimeOff();
            MessageBox.Show("You have approved this time off");
            RequestedTimeListBox.Items.Clear(); 
            ///To do 
            ///once button clicks the dates shown should be blocked off 
            ///on schedule
        }

        private void DenyTime()
        {
            string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];

            using (SqlConnection myconnection = new SqlConnection(str))
            using (SqlDataAdapter denytime = new SqlDataAdapter($"SELECT * FROM RequestTimeOff JOIN Employees ON RequestTimeOff.EmployeeID = Employees.EmployeeId WHERE FName = '{emFName}' AND LName = '{emLName}'", myconnection))
            {
                DataTable deny = new DataTable();

                myconnection.Open();
                denytime.Fill(deny);



                for (int row = 0; row < deny.Rows.Count; row++)
                {
                    int employeeid = (int)deny.Rows[row]["EmployeeID"];
                    SqlCommand RequestApproved = new SqlCommand($"update RequestTimeOff Set Status = 'Denied' " +
                        "WHERE EmployeeID = " + employeeid + "", myconnection);
                    RequestApproved.ExecuteNonQuery();
                }
                myconnection.Close();
            };
        }
        private void DenyTimeOffButton_Click(object sender, EventArgs e)
        {
            DenyTime();
            MessageBox.Show("You have denied this time off");
            RequestedTimeListBox.Items.Clear();
            ///to do5
            /// not sure???
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workersDataSet);

        }

        private void ApproveDenyTimeOff_Load(object sender, EventArgs e)
        {
            EmployeeName();
            CheckStatus();
        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
