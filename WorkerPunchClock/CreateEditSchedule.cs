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
    public partial class CreateEditSchedule : Form
    {
        public CreateEditSchedule()
        {
            InitializeComponent();
        }
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\coleb\Source\Repos\BowValleyCollegeDevTeam\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";

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
        private void CreateEditSchedule_Load(object sender, EventArgs e)
        {
            CheckStatus();
            newEditcmb.Items.Add("New Schedule");
            newEditcmb.Items.Add("Edit Schedule");
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
                        SelectEmployeeComboBox.Items.Add(FirstName + " " + LastName);
                    }


                }


            }
        }

        private void SelectEmployeeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            schedulelstbx.Items.Clear();
            nameLabel.Text = SelectEmployeeComboBox.Text;
        }

        private void enterTimebtn_Click(object sender, EventArgs e)
        {
            string daySchedule;
            daySchedule = datetxtbx.Text + " " + startTimetxtbx.Text + " - " + endTimetxtbx.Text;
   
            foreach (var x in schedulelstbx.Items)
            {
                if (daySchedule == x.ToString())
                {
                    MessageBox.Show("Duplicate entry");
                }
                else
                {
                    schedulelstbx.Items.Add(daySchedule);
                }
            }
            if(schedulelstbx.Items.Count == 0)
            {
                schedulelstbx.Items.Add(daySchedule);
            }
        }
        List<string> schedule = new List<string>();
        private void newEditcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newEditcmb.SelectedItem.ToString() == "Edit Schedule")
            {
                schedulelstbx.Items.Clear();
                enterTimebtn.Hide();
                scheduleSubmitbtn.Text = "Edit Selected Time";
            }
            else
            {
                schedulelstbx.Items.Clear();
                enterTimebtn.Show();
                scheduleSubmitbtn.Text = "Submit Schedule";
            }
            string[] selectedEmployee = SelectEmployeeComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];
            using (SqlConnection myConnection = new SqlConnection(str))
            using (SqlDataAdapter scheduleInfo = new SqlDataAdapter($"SELECT * FROM Schedule", myConnection))
            using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees WHERE FName = '{emFName}' AND LName = '{emLName}'", myConnection))
            {
                DataTable employee = new DataTable();
                DataTable schedule = new DataTable();
                myConnection.Open();
                employeeInfo.Fill(employee);
                scheduleInfo.Fill(schedule);
                for (int row = 0; row < employee.Rows.Count; row++)
                {
                    int employeeID = (int)employee.Rows[row]["EmployeeID"];
                    for (int x = 0; x < schedule.Rows.Count; x++)
                    {
                        DateTime startTime = (DateTime)schedule.Rows[x]["StartDateTime"];
                        DateTime endTime = (DateTime)schedule.Rows[x]["EndDateTime"];
                        schedulelstbx.Items.Add(startTime.ToString("yyyy-MM-dd HH:mm") + " - " + endTime.ToString("HH:mm"));
                    }

                }

            }
        }

        private void scheduleSubmitbtn_Click(object sender, EventArgs e)
        {
            if (SelectEmployeeComboBox.Text == "")
            {
                MessageBox.Show("No Employee has been selected");
            }
            if (newEditcmb.Text == "")
            {
                MessageBox.Show("Edit or Add Has Not Been Selected ");
            }
            string[] selectedEmployee = SelectEmployeeComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];
            using (SqlConnection myConnection = new SqlConnection(str))
            using (SqlDataAdapter scheduleInfo = new SqlDataAdapter($"SELECT * FROM Schedule", myConnection))
            using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees WHERE FName = '{emFName}' AND LName = '{emLName}'", myConnection))
            {
                DataTable employee = new DataTable();
                DataTable schedule = new DataTable();
                myConnection.Open();
                employeeInfo.Fill(employee);
                scheduleInfo.Fill(schedule);
                for (int row = 0; row < employee.Rows.Count; row++)
                {
                    int employeeID = (int)employee.Rows[row]["EmployeeID"];
                    if (newEditcmb.Text == "New Schedule")
                    {
                        foreach (var x in schedulelstbx.Items)
                        {
                            string[] getSchedule = x.ToString().Split(' ');
                            string schedulesemp = "INSERT INTO Schedule (EmployeeID,StartDateTime,EndDateTime) VALUES (" + employeeID + " , '" + DateTime.ParseExact(getSchedule[0] + " " + getSchedule[1], "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture) + "', '" + DateTime.ParseExact(getSchedule[0] + " " + getSchedule[3], "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture) + "');";

                            SqlCommand insertSchedule = new SqlCommand(schedulesemp, myConnection);
                            insertSchedule.ExecuteNonQuery();
                        }
                    }
                    for (int x = 0; x < schedule.Rows.Count; x++)
                    {
                        DateTime startTime = (DateTime)schedule.Rows[x]["StartDateTime"];
                        DateTime endTime = (DateTime)schedule.Rows[x]["EndDateTime"];


                        if (newEditcmb.Text == "Edit Schedule")
                        {
                            SqlCommand UpdateEmployeeInfo = new SqlCommand("UPDATE Schedule SET EmployeeID =" + employeeID + ", StartDateTime = '" + DateTime.ParseExact(datetxtbx.Text + " " + startTimetxtbx.Text, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture) + "', EndDateTime = '" +DateTime.ParseExact(datetxtbx.Text + " " + endTimetxtbx.Text, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture) + "' ;", myConnection);
                            UpdateEmployeeInfo.ExecuteNonQuery();
                            MessageBox.Show("Schedule has been updated");
                        }
                    }
                }




                //for (int row = 0; row < employee.Rows.Count; row++)
                //{
                //    string[] selectedEmployee = EmployeeNameComboBox.Text.Split(' ');
                //    string emFName = selectedEmployee[0];
                //    string emLName = selectedEmployee[1];
                //    string FirstName = (string)employee.Rows[row]["FName"];
                //    string LastName = (string)employee.Rows[row]["LName"];
                //    if (emFName == FirstName && emLName == LastName)
                //    {
                //        SqlCommand UpdateEmployeeInfo = new SqlCommand("UPDATE Employees SET PIN =" + Convert.ToInt32(PINTextBox.Text) + ", FName = '" + FirstNameTextBox.Text + "', LName = '" + LastNameTextBox.Text + "', DOB ='" + DateTime.ParseExact(DOBTextBox.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture) + "', Address ='" + AddressTextBox.Text + "', City = '" + CityTextBox.Text + "', Province = '" + ProvinceTextBox.Text + "', [Start Date] = '" + DateTime.ParseExact(StartDateTextBox.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture) + "', Position = '" + positiontxtbx.Text + "', Wage = '" + Convert.ToDecimal(WageTextBox.Text) + "', Status = 0 WHERE FName = '" + FirstName + "' AND LName = '" + LastName + "' ;", myConnection);
                //        UpdateEmployeeInfo.ExecuteNonQuery();
                //        MessageBox.Show("User has been updated");
                //    }

                //}
                myConnection.Close();
            }
        }

        private void schedulelstbx_MouseClick(object sender, MouseEventArgs e)
        {
            string selected = schedulelstbx.SelectedItem.ToString();
            string[] change = selected.Split(' ');
            datetxtbx.Text = change[0];
            startTimetxtbx.Text = change[1];
            endTimetxtbx.Text = change[3];

        }
    }
}
