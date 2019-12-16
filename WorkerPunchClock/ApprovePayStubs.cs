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
    public partial class ApprovePayStubs : Form
    {
        // please change this to your own connection string
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\coleb\Source\Repos\BowValleyCollegeDevTeam\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";
        // we use this string to locally use the database so there is no runtime errors
        public ApprovePayStubs()
        {
            InitializeComponent();
            
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
                // goes through and grabs multiple names
                for (int row = 0; row < getEmp.Rows.Count; row++)
                {
                    string FirstName = (string)getEmp.Rows[row]["FName"];
                    string LastName = (string)getEmp.Rows[row]["LName"];
                    // Adds all the names into the combo box
                    this.EmployeeNameComboBox.Items.Add(FirstName + " " + LastName);
                }
            };
        }

        private void PayPeriod()
        {
            // depending on which employee is in the employee combo box
            // the pay period  combo box changes to suply all the pay periods in the database
            string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];
            // splits the employee name from the combo box so that you can use it for the select statement
            using (SqlConnection myconnection = new SqlConnection(str))
            using (SqlDataAdapter PayP = new SqlDataAdapter($"SELECT * FROM PayStub JOIN Employees ON PayStub.EmployeeID = Employees.EmployeeId WHERE FName = '{emFName}' AND LName = '{emLName}'", myconnection))
            {
                DataTable getPay = new DataTable();

                myconnection.Open();
                PayP.Fill(getPay);
                myconnection.Close();

                for (int row = 0; row < getPay.Rows.Count; row++)
                {
                    DateTime sd = (DateTime)getPay.Rows[row]["StartDatePeriod"];
                    DateTime ed = (DateTime)getPay.Rows[row]["EndDatePeriod"];
                    
                    // adds the pay period to the combo box
                    this.PayPeriodComboBox.Items.Add($"{sd}  {ed}");
                }
            };
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            //what happens when you click the approve button
            // once you hit it, it clears everything that has been displayed so far
            MessageBox.Show("You have approved this Pay Stub");
            PaystubListBox.Items.Clear();
            PayPeriodComboBox.Items.Clear();

        }

        private void EmployeeNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // changes the paystub combo box everytime you change the name in the Employee combo box
            PayPeriodComboBox.Items.Clear();
            PayPeriod();
        }

        private void PayStubInfo()
        {
            // grabs the paystub info depending on what the employee combo box and pay period combo box say
            string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];
            // splits the employee name from the combo box so that you can use it for the select statement
            using (SqlConnection myconnection = new SqlConnection(str))
            using (SqlDataAdapter PayS = new SqlDataAdapter($"SELECT * FROM PayStub JOIN Employees ON PayStub.EmployeeID = Employees.EmployeeId WHERE FName = '{emFName}' AND LName = '{emLName}'", myconnection))
            {
                DataTable getps = new DataTable();

                myconnection.Open();
                PayS.Fill(getps);
                myconnection.Close();

                for (int row = 0; row < getps.Rows.Count; row++)
                {
                    int psid = (int)getps.Rows[row]["PayStubID"];
                    decimal th = (decimal)getps.Rows[row]["TotalHours"];
                    decimal tp = (decimal)getps.Rows[row]["TotalPay"];
                    // displays the paystub in the list box
                    PaystubListBox.Items.Add($"ID: {psid, -20}  Total Hours: {th, -20} Total Pay: {tp,-20}");                    
                }
            };
        }

        private void PayPeriodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // every time you change what the pay period combo box displays in changes what values you see in the list box
            PaystubListBox.Items.Clear();
            PayStubInfo();
        }
        
        private void ApprovePayStubs_Load(object sender, EventArgs e)
        {
            // as soon as the form loads it runs these to functions
            EmployeeName();
            CheckStatus();
        }
    }
}
