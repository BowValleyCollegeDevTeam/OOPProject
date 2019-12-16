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
    //Coded by Ana Siemens
    public partial class ApproveDenyTimeOff : Form
    {
        // please change this to your own connection string 
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\coleb\Source\Repos\BowValleyCollegeDevTeam\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";
        // we use this string to locally use the database so there is no runtime errors
        public ApproveDenyTimeOff()
        {
            InitializeComponent();
            EmployeeName();
        }

        public void CheckStatus()
        {
            //This checks the status of the Employee from the database.
            //Sets the top menu bar values equal to the values in the database for the employee.

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
            // connects to the databse to grab all the employee names
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
                    // Adds all the names into the combo box
                    this.EmployeeNameComboBox.Items.Add(FirstName +" "+ LastName);
                }
            };
        }
        private void RequestedTimeOff()
        {
            // depending on the employee name it will display their requested time off
            string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];
            // splits the employee name from the combo box so that you can use it for the select statement
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
            // runs everytime the employee combo box is changed
        }

        private void ApproveTimeOff()
        {
            // grabs the requested time off from the databse
            // depending on the employee name
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
                    // updates the database whether their requested time off is aprroved or denied
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
            // grabs the requested time off from the databse
            // depending on the employee name
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
                    // updates the database whether their requested time off is aprroved or denied
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
