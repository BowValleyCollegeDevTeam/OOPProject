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
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heart\repos\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";
        public ApproveDenyTimeOff()
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
                    this.EmployeeNameComboBox.Items.Add(FirstName + LastName);
                }
            };
        }
        private void RequestedTimeOff()
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
                    this.EmployeeNameComboBox.Items.Add(FirstName + LastName);
                }
            };
        }
        private void EmployeeNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            /// TO DO
            /// This should display the employee names
            /// depending on the employee name it should
            /// change what gets displayed in the timeoff panel
        }

        private void ApproveTimeOffButton_Click(object sender, EventArgs e)
        {
            
            ///To do 
            ///once button clicks the dates shown should be blocked off 
            ///on schedule
        }

        private void DenyTimeOffButton_Click(object sender, EventArgs e)
        {
            ///to do
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
            // TODO: This line of code loads data into the 'workersDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.workersDataSet.Employees);

        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
