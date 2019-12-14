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
    public partial class TopInfoBar : UserControl
    {
        public TopInfoBar()
        {
            InitializeComponent();
            TimeTimerTicker.Start();
   

        }
        
        //private string dbConnectionString;

        private void TimeTimerTicker_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.TimeLabel.Text = dateTime.ToString();
          
        }

        //public void getData()
        //{
        //    dbConnectionString = ConfigurationManager.ConnectionStrings["WorkerPunchClock.Properties.Settings.WorkersConnectionString"].ConnectionString;
        //    using (StaffLogin login = new StaffLogin())
        //    using (SqlConnection myConnection = new SqlConnection(dbConnectionString))
        //    using (SqlDataAdapter employeePin = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {login.pin}", myConnection))
        //    {
        //        DataTable userPin = new DataTable();

        //        myConnection.Open();
        //        employeePin.Fill(userPin);
        //        myConnection.Close();
        //        for (int row = 0; row < userPin.Rows.Count; row++)
        //        {
        //            string FirstName = (string)userPin.Rows[row]["FName"];
        //            string LastName = (string)userPin.Rows[row]["LName"];
        //            StaffNameLabel.Text = "Name: " + FirstName + " " + LastName;
        //        }
        //    }
        //}

        private void TopInfoBar_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
