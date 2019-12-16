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
    public partial class TopBar : UserControl
    {
        public TopBar()
        {
            InitializeComponent();
        }
        private string dbConnectionString;

        private void GetData()
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["WorkerPunchClock.Properties.Settings.WorkersConnectionString"].ConnectionString;
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(dbConnectionString))
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
                    StaffNameLabel.Text = "Name: " + FirstName + " " + LastName;
                }
            }
        }

        private void TopBarLoad(object sender, EventArgs e)
        {
        }

        private void TopBarPaint(object sender, PaintEventArgs e)
        {
            GetData();
        }
    }
}
