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
        // Kara Myers did this page
        // also created the database

        public CreateEditSchedule()
        {
            InitializeComponent();
        }
        // this is the string for the local database and must be changed on your computer if you click the server explorer and select the database in the properties take that connection string and copy and paste in the ""
        public string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\coleb\Source\Repos\BowValleyCollegeDevTeam\OOPProject\WorkerPunchClock\Workers.mdf;Integrated Security=True";

        public void CheckStatus()
        {
            //grabs the login though an instance of sStaff login
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(str))
                // selects all from employees where employee pin is equal to login pin
            using (SqlDataAdapter employeePin = new SqlDataAdapter($"SELECT * FROM Employees WHERE PIN = {login.pin}", myConnection))
            {
                // makes new empty table for userpin
                DataTable userPin = new DataTable();

                // opens and filll userpin with employee information
                myConnection.Open();
                employeePin.Fill(userPin);
                myConnection.Close();
                for (int row = 0; row < userPin.Rows.Count; row++)
                {
                    //grabs first name, last name and status
                    string FirstName = (string)userPin.Rows[row]["FName"];
                    string LastName = (string)userPin.Rows[row]["LName"];
                    bool Status = (bool)userPin.Rows[row]["Status"];
                    //puts the user information of first name, last name and status and changes the top info bar
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
            // adds new schedule and edit schedule to new and edit combo box
            newEditcmb.Items.Add("New Schedule");
            newEditcmb.Items.Add("Edit Schedule");
            using (StaffLogin login = new StaffLogin())
            using (SqlConnection myConnection = new SqlConnection(str))
            {
                // selects from employees
                using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees", myConnection))
                {
                    // creates new empty table
                    DataTable employee = new DataTable();
                    // fills employee table with employee information
                    myConnection.Open();
                    employeeInfo.Fill(employee);
                    myConnection.Close();

                    for (int row = 0; row < employee.Rows.Count; row++)
                    {
                        // adds fristname and lastname to the select employee combobox
                        string FirstName = (string)employee.Rows[row]["FName"];
                        string LastName = (string)employee.Rows[row]["LName"];
                        SelectEmployeeComboBox.Items.Add(FirstName + " " + LastName);
                    }


                }


            }
        }
        // selects employee from combobox and clear the listbox on selected value change
        private void SelectEmployeeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            schedulelstbx.Items.Clear();
            nameLabel.Text = SelectEmployeeComboBox.Text;
        }

        // on enter time button will add schedule the listbox
        private void enterTimebtn_Click(object sender, EventArgs e)
        {
            string daySchedule;
            daySchedule = datetxtbx.Text + " " + startTimetxtbx.Text + " - " + endTimetxtbx.Text;
   
            foreach (var x in schedulelstbx.Items)
            {
                if (daySchedule == x.ToString())
                {
                    // handles for duplicate entry
                    MessageBox.Show("Duplicate entry");
                }
                else
                {
                    // adds to list box
                    schedulelstbx.Items.Add(daySchedule);
                }
            }
            if(schedulelstbx.Items.Count == 0)
            {
                // adds day if count is equal to 0
                schedulelstbx.Items.Add(daySchedule);
            }
        }
        // creates new schedule list
        List<string> schedule = new List<string>();
        // handles for edit and create new schedule 
        private void newEditcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // id edit clears Items in the list box and hides the enter time button and changes the submit schedule to edit selected time
            if (newEditcmb.SelectedItem.ToString() == "Edit Schedule")
            {
                schedulelstbx.Items.Clear();
                enterTimebtn.Hide();
                scheduleSubmitbtn.Text = "Edit Selected Time";
            }
            else
            {
                // else shows the enter time button and clears the listbox and changes submit button to submit schedule
                schedulelstbx.Items.Clear();
                enterTimebtn.Show();
                scheduleSubmitbtn.Text = "Submit Schedule";
            }
            // gets selected employee by splitting the string and assigning them to employee name
            string[] selectedEmployee = SelectEmployeeComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];
            using (SqlConnection myConnection = new SqlConnection(str))
                // selects from schedule and employees
            using (SqlDataAdapter scheduleInfo = new SqlDataAdapter($"SELECT * FROM Schedule", myConnection))
            using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees WHERE FName = '{emFName}' AND LName = '{emLName}'", myConnection))
            {
                // creates new empty tables
                DataTable employee = new DataTable();
                DataTable schedule = new DataTable();
                myConnection.Open();
                // fills tables with employee and schedule data
                employeeInfo.Fill(employee);
                scheduleInfo.Fill(schedule);
                for (int row = 0; row < employee.Rows.Count; row++)
                {
                    // for selected employee grabs all of the schedule times from the database and adds to list box
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

        // Updates or inserts data into the database on button click
        private void scheduleSubmitbtn_Click(object sender, EventArgs e)
        {
            // handles for boxes not being filled in
            if (SelectEmployeeComboBox.Text == "")
            {
                MessageBox.Show("No Employee has been selected");
            }
            if (newEditcmb.Text == "")
            {
                MessageBox.Show("Edit or Add Has Not Been Selected ");
            }
            // gets selected employee by splitting the string and assigning them to employee name
            string[] selectedEmployee = SelectEmployeeComboBox.Text.Split(' ');
            string emFName = selectedEmployee[0];
            string emLName = selectedEmployee[1];
            using (SqlConnection myConnection = new SqlConnection(str))
            // selects from schedule and employees

            using (SqlDataAdapter scheduleInfo = new SqlDataAdapter($"SELECT * FROM Schedule", myConnection))
            using (SqlDataAdapter employeeInfo = new SqlDataAdapter($"SELECT * FROM Employees WHERE FName = '{emFName}' AND LName = '{emLName}'", myConnection))
            {
                // creates empty tables
                DataTable employee = new DataTable();
                DataTable schedule = new DataTable();
                myConnection.Open();
                // fills employee and schedule tables
                employeeInfo.Fill(employee);
                scheduleInfo.Fill(schedule);
                for (int row = 0; row < employee.Rows.Count; row++)
                {
                    int employeeID = (int)employee.Rows[row]["EmployeeID"];
                    // if new schedule where name is equal to employee id insert vales into database
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

                        // if edit schedule updates selected item
                        if (newEditcmb.Text == "Edit Schedule")
                        {
                            SqlCommand UpdateEmployeeInfo = new SqlCommand("UPDATE Schedule SET EmployeeID =" + employeeID + ", StartDateTime = '" + DateTime.ParseExact(datetxtbx.Text + " " + startTimetxtbx.Text, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture) + "', EndDateTime = '" +DateTime.ParseExact(datetxtbx.Text + " " + endTimetxtbx.Text, "yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.InvariantCulture) + "' ;", myConnection);
                            UpdateEmployeeInfo.ExecuteNonQuery();
                            MessageBox.Show("Schedule has been updated");
                        }
                    }
                }

                myConnection.Close();
            }
        }

        private void schedulelstbx_MouseClick(object sender, MouseEventArgs e)
        {
            // grabs selected list box item
            string selected = schedulelstbx.SelectedItem.ToString();
            string[] change = selected.Split(' ');
            datetxtbx.Text = change[0];
            startTimetxtbx.Text = change[1];
            endTimetxtbx.Text = change[3];

        }
    }
}
