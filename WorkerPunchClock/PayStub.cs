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
    public partial class PayStub : Form
    {
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ajdon\Documents\GitHub\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security = True";

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

        public PayStub()
        {
            InitializeComponent();
        }

        private void PayStubMainMenuButton_Click(object sender, EventArgs e)
        {
            new StaffMainMenu().Show();
        }

        private void payStubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PayStub_Load(object sender, EventArgs e)
        {
            CheckStatus();
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
                    }                    
                }
                using (SqlDataAdapter clientPayStubAdapter = new SqlDataAdapter($"SELECT * FROM Paystub WHERE EmployeeID = {employeeID}", myConnection))
                {
                    DataTable clientPayStub = new DataTable();

                    myConnection.Open();
                    clientPayStubAdapter.Fill(clientPayStub);
                    myConnection.Close();
                    for (int row = 0; row < clientPayStub.Rows.Count; row++)
                    {
                        int payStubID = (int)clientPayStub.Rows[row]["PayStubID"];
                        decimal totalHours = (decimal)clientPayStub.Rows[row]["TotalHours"];
                        decimal totalPay = (decimal)clientPayStub.Rows[row]["TotalPay"];

                        payStubListBox.Items.Add($"ID: {payStubID, -20} Total Hours: {totalHours, -20} Total Pay: {totalPay, -20} ");
                    }
                }

            }
        }
    }
}
