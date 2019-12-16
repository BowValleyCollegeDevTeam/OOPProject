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
    public partial class CreateEditEmployee : Form
    {
        // Kara Myers did this page
        // also created the database
        public CreateEditEmployee()
        {
            InitializeComponent();
        }

        // this is the string for the local database and must be changed on your computer if you click the server explorer and select the database in the properties take that connection string and copy and paste in the ""
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\coleb\Source\Repos\BowValleyCollegeDevTeam\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";
        // checks status gets employee based off user pin and populates the top info bar with current emploee and gets status for clocked in or clocked out
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
                    //gets the first name, last name and status and changes the info bar based on employee logged in 
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
        private void CreateEditEmployee_Load(object sender, EventArgs e)
        {
            // checks status on every load
            CheckStatus();
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(str))
            {
                // Adds a new Employee option to the combo box
                EmployeeNameComboBox.Items.Add("New Employee");
                // gets all employees from database
                using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees", myConnection))
                {
                    //creates empty table
                    DataTable employee = new DataTable();
                    // opens connection and populates table
                    myConnection.Open();
                    employeeInfo.Fill(employee);
                    myConnection.Close();
                    // for every employee in employees it adds to the employee combo box
                    for (int row = 0; row < employee.Rows.Count; row++)
                    {
                        string FirstName = (string)employee.Rows[row]["FName"];
                        string LastName = (string)employee.Rows[row]["LName"];
                        EmployeeNameComboBox.Items.Add(FirstName + " " + LastName);
                    }


                }


            }

        }

        private void EmployeeNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // sets all the boxes to empty if new employee is selected
            if ( EmployeeNameComboBox.Text == "New Employee")
            {
                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                PINTextBox.Text = "";
                DOBTextBox.Text = "";
                AddressTextBox.Text = "";
                CityTextBox.Text = "";
                ProvinceTextBox.Text = "";
                StartDateTextBox.Text = "";
                WageTextBox.Text = "";
                positiontxtbx.Text = "";
            }
            // splits the name of the combo box in order to get employee first and last name
            string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];
            using (SqlConnection myConnection = new SqlConnection(str))
                // selects from employees where first name and last name is equal to the selected employee
            using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees WHERE FName = '{emFName}' AND LName = '{emLName}' ", myConnection))
            {
                // creates empty table
                DataTable employee = new DataTable();

                //opens connection and fills the employee table
                myConnection.Open();
                employeeInfo.Fill(employee);
                myConnection.Close();

                // grabs the info from employee and fills the the approprate textboxes
                for (int row = 0; row < employee.Rows.Count; row++)
                {
                    string FirstName = (string)employee.Rows[row]["FName"];
                    string LastName = (string)employee.Rows[row]["LName"];
                    int PIN = (int)employee.Rows[row]["PIN"];
                    DateTime dob = (DateTime)employee.Rows[row]["DOB"];
                    string address = (string)employee.Rows[row]["Address"];
                    string city = (string)employee.Rows[row]["City"];
                    string province = (string)employee.Rows[row]["Province"];
                    DateTime startDate = (DateTime)employee.Rows[row]["Start Date"];
                    decimal wage = (decimal)employee.Rows[row]["Wage"];
                    string position = (string)employee.Rows[row]["Position"];
                    FirstNameTextBox.Text = FirstName;
                    LastNameTextBox.Text = LastName;
                    PINTextBox.Text = PIN.ToString();
                    DOBTextBox.Text = dob.ToString("yyyy/MM/dd");
                    AddressTextBox.Text = address;
                    CityTextBox.Text = city;
                    ProvinceTextBox.Text = province;
                    StartDateTextBox.Text = startDate.ToString("yyyy/MM/dd");
                    WageTextBox.Text = wage.ToString();
                    positiontxtbx.Text = position.ToString();

                }

            }

        }

        private void AddEditEmployeeButton_Click(object sender, EventArgs e)
        {

                using (SqlConnection myConnection = new SqlConnection(str))
                // selects all from the employees table
                using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees", myConnection))
                {
                // creates new employee table that is empty
                    DataTable employee = new DataTable();
                    
                    // Opens and fills the employee table with employee data
                    myConnection.Open();
                    employeeInfo.Fill(employee);

                // if it is New employee insert into employees
                    if (EmployeeNameComboBox.Text == "New Employee")
                    {
                        SqlCommand insertEmployee = new SqlCommand("INSERT INTO Employees (PIN,FName,LName,DOB,Address,City,Province,[Start Date],Position,Wage,Status) VALUES (" + Convert.ToInt32(PINTextBox.Text) + " , '" + FirstNameTextBox.Text + "', '" + LastNameTextBox.Text + "', '" + DateTime.ParseExact(DOBTextBox.Text, "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture) + "', '" + AddressTextBox.Text + "', '" + CityTextBox.Text + "', '" + ProvinceTextBox.Text + "', '" + DateTime.ParseExact(StartDateTextBox.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture) + "', '" + positiontxtbx.Text + "', '" + Convert.ToDecimal(WageTextBox.Text) + "' , 0);", myConnection);
                        insertEmployee.ExecuteNonQuery();
                        MessageBox.Show("Employee has been added");
                    }
                    // if the user is selected edits employee and updates the database 
                    for (int row = 0; row < employee.Rows.Count; row++)
                    {
                        string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
                        string emFName = selectedEmployee[0];
                        string emLName = selectedEmployee[1];
                        string FirstName = (string)employee.Rows[row]["FName"];
                        string LastName = (string)employee.Rows[row]["LName"];
                        if(emFName == FirstName && emLName == LastName)
                        {
                             SqlCommand UpdateEmployeeInfo = new SqlCommand("UPDATE Employees SET PIN =" + Convert.ToInt32(PINTextBox.Text) + ", FName = '" + FirstNameTextBox.Text + "', LName = '" + LastNameTextBox.Text + "', DOB ='" + DateTime.ParseExact(DOBTextBox.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture) + "', Address ='" + AddressTextBox.Text + "', City = '" + CityTextBox.Text + "', Province = '" + ProvinceTextBox.Text + "', [Start Date] = '" + DateTime.ParseExact(StartDateTextBox.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture) + "', Position = '" + positiontxtbx.Text + "', Wage = '" + Convert.ToDecimal(WageTextBox.Text) + "', Status = 0 WHERE FName = '" + FirstName + "' AND LName = '" + LastName + "' ;", myConnection);
                             UpdateEmployeeInfo.ExecuteNonQuery();
                             MessageBox.Show("User has been updated");
                        }

                }
                    myConnection.Close();
                }
        }
    }
}
