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
        }
    }
}
