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
        public CreateEditEmployee()
        {
            InitializeComponent();
        }
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kara\Source\Repos\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";

        private void CreateEditEmployee_Load(object sender, EventArgs e)
        {
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(str))
            {
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
                EmployeeNameComboBox.Items.Add("New Employee");
                using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees", myConnection))
                {
                    DataTable employee = new DataTable();

                    myConnection.Open();
                    employeeInfo.Fill(employee);
                    myConnection.Close();

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
            string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];
            using (SqlConnection myConnection = new SqlConnection(str))
            using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees WHERE FName = '{emFName}' AND LName = '{emLName}' ", myConnection))
            {
                DataTable employee = new DataTable();

                myConnection.Open();
                employeeInfo.Fill(employee);
                myConnection.Close();

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
                using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees", myConnection))
                {
                    DataTable employee = new DataTable();

                    myConnection.Open();
                    employeeInfo.Fill(employee);

                    if (EmployeeNameComboBox.Text == "New Employee")
                    {
                        SqlCommand insertEmployee = new SqlCommand("INSERT INTO Employees (PIN,FName,LName,DOB,Address,City,Province,[Start Date],Position,Wage,Status) VALUES (" + Convert.ToInt32(PINTextBox.Text) + " , '" + FirstNameTextBox.Text + "', '" + LastNameTextBox.Text + "', '" + DateTime.ParseExact(DOBTextBox.Text, "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture) + "', '" + AddressTextBox.Text + "', '" + CityTextBox.Text + "', '" + ProvinceTextBox.Text + "', '" + DateTime.ParseExact(StartDateTextBox.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture) + "', '" + positiontxtbx.Text + "', '" + Convert.ToDecimal(WageTextBox.Text) + "' , 0);", myConnection);
                        insertEmployee.ExecuteNonQuery();
                        MessageBox.Show("Employee has been added");
                    }

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

                        }

                }
                    myConnection.Close();
                }
        }
    }
}
