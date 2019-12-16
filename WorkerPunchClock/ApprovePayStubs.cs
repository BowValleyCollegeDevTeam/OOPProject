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
    public partial class ApprovePayStubs : Form
    {
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heart\repos\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";
        public ApprovePayStubs()
        {
            InitializeComponent();
            EmployeeName();
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
                    this.EmployeeNameComboBox.Items.Add(FirstName + " " + LastName);
                }
            };
        }

        private void PayPeriod()
        {
            string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];

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
                    

                    this.PayPeriodComboBox.Items.Add($"{sd}  {ed}");
                }
            };
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have approved this Pay Stub");
            PaystubListBox.Items.Clear();
            PayPeriodComboBox.Items.Clear();

        }

        private void EmployeeNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PayPeriodComboBox.Items.Clear();
            PayPeriod();
        }

        private void PayStubInfo()
        {
            string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];

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

                    PaystubListBox.Items.Add($"ID: {psid, -20}  Total Hours: {th, -20} Total Pay: {tp,-20}");                    
                }
            };
        }

        private void PayPeriodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaystubListBox.Items.Clear();
            PayStubInfo();
        }
    }
}
