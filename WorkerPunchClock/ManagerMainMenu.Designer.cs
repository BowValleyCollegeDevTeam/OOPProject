namespace WorkerPunchClock
{
    partial class ManagerMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.NameSplitter = new System.Windows.Forms.Splitter();
            this.PayStubLabel = new System.Windows.Forms.Label();
            this.RequestTimeOffLabel = new System.Windows.Forms.Label();
            this.ClockInOutLabel = new System.Windows.Forms.Label();
            this.WorkScheduleLabel = new System.Windows.Forms.Label();
            this.CreateEditScheduleLabel = new System.Windows.Forms.Label();
            this.CreateEditEmployeeLabel = new System.Windows.Forms.Label();
            this.ApprovePayStubsLabel = new System.Windows.Forms.Label();
            this.ApproveDenyTimeOffPictureBox = new System.Windows.Forms.PictureBox();
            this.ApprovePayStubsPictureBox = new System.Windows.Forms.PictureBox();
            this.CreateEditEmployeePictureBox = new System.Windows.Forms.PictureBox();
            this.CreateEditSchedulePictureBox = new System.Windows.Forms.PictureBox();
            this.PayStubPictureBox = new System.Windows.Forms.PictureBox();
            this.RequestTimeOffPictureBox = new System.Windows.Forms.PictureBox();
            this.ClockInOutPictureBox = new System.Windows.Forms.PictureBox();
            this.WorkSchedulePictureBox = new System.Windows.Forms.PictureBox();
            this.ApproveDenyTimeOffLabel = new System.Windows.Forms.Label();
            this.ManagerPageTimer = new System.Windows.Forms.Timer(this.components);
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersDataSet = new WorkerPunchClock.WorkersDataSet();
            this.employeesTableAdapter = new WorkerPunchClock.WorkersDataSetTableAdapters.EmployeesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApproveDenyTimeOffPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovePayStubsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateEditEmployeePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateEditSchedulePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayStubPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestTimeOffPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockInOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkSchedulePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.StaffNameLabel);
            this.panel1.Controls.Add(this.NameSplitter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 2;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(143, 8);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(144, 13);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "00/00/0000 0:00:00 AM";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(137, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(162, 32);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // StaffNameLabel
            // 
            this.StaffNameLabel.AutoSize = true;
            this.StaffNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameLabel.Location = new System.Drawing.Point(11, 8);
            this.StaffNameLabel.Name = "StaffNameLabel";
            this.StaffNameLabel.Size = new System.Drawing.Size(116, 13);
            this.StaffNameLabel.TabIndex = 1;
            this.StaffNameLabel.Text = "Name: Cole Tucker";
            // 
            // NameSplitter
            // 
            this.NameSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NameSplitter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NameSplitter.Enabled = false;
            this.NameSplitter.Location = new System.Drawing.Point(0, 0);
            this.NameSplitter.Name = "NameSplitter";
            this.NameSplitter.Size = new System.Drawing.Size(137, 32);
            this.NameSplitter.TabIndex = 0;
            this.NameSplitter.TabStop = false;
            // 
            // PayStubLabel
            // 
            this.PayStubLabel.AutoSize = true;
            this.PayStubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayStubLabel.Location = new System.Drawing.Point(669, 212);
            this.PayStubLabel.Name = "PayStubLabel";
            this.PayStubLabel.Size = new System.Drawing.Size(70, 16);
            this.PayStubLabel.TabIndex = 16;
            this.PayStubLabel.Text = "Pay Stub";
            this.PayStubLabel.MouseLeave += new System.EventHandler(this.PayStubMouseLeave);
            this.PayStubLabel.MouseHover += new System.EventHandler(this.PayStubMouseHover);
            // 
            // RequestTimeOffLabel
            // 
            this.RequestTimeOffLabel.AutoSize = true;
            this.RequestTimeOffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestTimeOffLabel.Location = new System.Drawing.Point(424, 212);
            this.RequestTimeOffLabel.Name = "RequestTimeOffLabel";
            this.RequestTimeOffLabel.Size = new System.Drawing.Size(128, 16);
            this.RequestTimeOffLabel.TabIndex = 14;
            this.RequestTimeOffLabel.Text = "Request Time Off";
            this.RequestTimeOffLabel.MouseLeave += new System.EventHandler(this.RequestTimeOffMouseLeave);
            this.RequestTimeOffLabel.MouseHover += new System.EventHandler(this.RequestTimeOffMouseHover);
            // 
            // ClockInOutLabel
            // 
            this.ClockInOutLabel.AutoSize = true;
            this.ClockInOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockInOutLabel.Location = new System.Drawing.Point(238, 212);
            this.ClockInOutLabel.Name = "ClockInOutLabel";
            this.ClockInOutLabel.Size = new System.Drawing.Size(91, 16);
            this.ClockInOutLabel.TabIndex = 12;
            this.ClockInOutLabel.Text = "Clock In/Out";
            this.ClockInOutLabel.MouseLeave += new System.EventHandler(this.ClockInOutMouseLeave);
            this.ClockInOutLabel.MouseHover += new System.EventHandler(this.ClockInOutMouseHover);
            // 
            // WorkScheduleLabel
            // 
            this.WorkScheduleLabel.AutoSize = true;
            this.WorkScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkScheduleLabel.Location = new System.Drawing.Point(22, 212);
            this.WorkScheduleLabel.Name = "WorkScheduleLabel";
            this.WorkScheduleLabel.Size = new System.Drawing.Size(113, 16);
            this.WorkScheduleLabel.TabIndex = 10;
            this.WorkScheduleLabel.Text = "Work Schedule";
            this.WorkScheduleLabel.MouseLeave += new System.EventHandler(this.WorkScheduleMouseLeave);
            this.WorkScheduleLabel.MouseHover += new System.EventHandler(this.WorkScheduleMouseHover);
            // 
            // CreateEditScheduleLabel
            // 
            this.CreateEditScheduleLabel.AutoSize = true;
            this.CreateEditScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEditScheduleLabel.Location = new System.Drawing.Point(8, 407);
            this.CreateEditScheduleLabel.Name = "CreateEditScheduleLabel";
            this.CreateEditScheduleLabel.Size = new System.Drawing.Size(155, 16);
            this.CreateEditScheduleLabel.TabIndex = 20;
            this.CreateEditScheduleLabel.Text = "Create/Edit Schedule";
            this.CreateEditScheduleLabel.MouseLeave += new System.EventHandler(this.CreateEditScheduleMouseLeave);
            this.CreateEditScheduleLabel.MouseHover += new System.EventHandler(this.CreateEditScheduleMouseHover);
            // 
            // CreateEditEmployeeLabel
            // 
            this.CreateEditEmployeeLabel.AutoSize = true;
            this.CreateEditEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEditEmployeeLabel.Location = new System.Drawing.Point(199, 407);
            this.CreateEditEmployeeLabel.Name = "CreateEditEmployeeLabel";
            this.CreateEditEmployeeLabel.Size = new System.Drawing.Size(160, 16);
            this.CreateEditEmployeeLabel.TabIndex = 21;
            this.CreateEditEmployeeLabel.Text = "Create/Edit Employee";
            this.CreateEditEmployeeLabel.MouseLeave += new System.EventHandler(this.CreateEditEmployeeMouseLeave);
            this.CreateEditEmployeeLabel.MouseHover += new System.EventHandler(this.CreateEditEmployeeMouseHover);
            // 
            // ApprovePayStubsLabel
            // 
            this.ApprovePayStubsLabel.AutoSize = true;
            this.ApprovePayStubsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprovePayStubsLabel.Location = new System.Drawing.Point(418, 407);
            this.ApprovePayStubsLabel.Name = "ApprovePayStubsLabel";
            this.ApprovePayStubsLabel.Size = new System.Drawing.Size(137, 16);
            this.ApprovePayStubsLabel.TabIndex = 22;
            this.ApprovePayStubsLabel.Text = "Approve PayStubs";
            this.ApprovePayStubsLabel.MouseLeave += new System.EventHandler(this.ApprovePayStubsMouseLeave);
            this.ApprovePayStubsLabel.MouseHover += new System.EventHandler(this.ApprovePayStubsMouseHover);
            // 
            // ApproveDenyTimeOffPictureBox
            // 
            this.ApproveDenyTimeOffPictureBox.Image = global::WorkerPunchClock.Properties.Resources.AcceptRequestedTimeOffIcon;
            this.ApproveDenyTimeOffPictureBox.Location = new System.Drawing.Point(612, 253);
            this.ApproveDenyTimeOffPictureBox.Name = "ApproveDenyTimeOffPictureBox";
            this.ApproveDenyTimeOffPictureBox.Size = new System.Drawing.Size(176, 142);
            this.ApproveDenyTimeOffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ApproveDenyTimeOffPictureBox.TabIndex = 23;
            this.ApproveDenyTimeOffPictureBox.TabStop = false;
            this.ApproveDenyTimeOffPictureBox.Click += new System.EventHandler(this.ApproveDenyTimeOffPictureBox_Click);
            this.ApproveDenyTimeOffPictureBox.MouseLeave += new System.EventHandler(this.ApproveDenyTimeOffMouseLeave);
            this.ApproveDenyTimeOffPictureBox.MouseHover += new System.EventHandler(this.ApproveDenyTimeOffMouseHover);
            // 
            // ApprovePayStubsPictureBox
            // 
            this.ApprovePayStubsPictureBox.Image = global::WorkerPunchClock.Properties.Resources.AcceptPayStubIcon;
            this.ApprovePayStubsPictureBox.Location = new System.Drawing.Point(400, 253);
            this.ApprovePayStubsPictureBox.Name = "ApprovePayStubsPictureBox";
            this.ApprovePayStubsPictureBox.Size = new System.Drawing.Size(168, 142);
            this.ApprovePayStubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ApprovePayStubsPictureBox.TabIndex = 19;
            this.ApprovePayStubsPictureBox.TabStop = false;
            this.ApprovePayStubsPictureBox.Click += new System.EventHandler(this.ApprovePayStubsPictureBox_Click);
            this.ApprovePayStubsPictureBox.MouseLeave += new System.EventHandler(this.ApprovePayStubsMouseLeave);
            this.ApprovePayStubsPictureBox.MouseHover += new System.EventHandler(this.ApprovePayStubsMouseHover);
            // 
            // CreateEditEmployeePictureBox
            // 
            this.CreateEditEmployeePictureBox.Image = global::WorkerPunchClock.Properties.Resources.AddEditEmployeeIcon;
            this.CreateEditEmployeePictureBox.Location = new System.Drawing.Point(199, 253);
            this.CreateEditEmployeePictureBox.Name = "CreateEditEmployeePictureBox";
            this.CreateEditEmployeePictureBox.Size = new System.Drawing.Size(162, 142);
            this.CreateEditEmployeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreateEditEmployeePictureBox.TabIndex = 18;
            this.CreateEditEmployeePictureBox.TabStop = false;
            this.CreateEditEmployeePictureBox.Click += new System.EventHandler(this.CreateEditEmployeePictureBox_Click);
            this.CreateEditEmployeePictureBox.MouseLeave += new System.EventHandler(this.CreateEditEmployeeMouseLeave);
            this.CreateEditEmployeePictureBox.MouseHover += new System.EventHandler(this.CreateEditEmployeeMouseHover);
            // 
            // CreateEditSchedulePictureBox
            // 
            this.CreateEditSchedulePictureBox.Image = global::WorkerPunchClock.Properties.Resources.EditScheduleIcon;
            this.CreateEditSchedulePictureBox.Location = new System.Drawing.Point(12, 253);
            this.CreateEditSchedulePictureBox.Name = "CreateEditSchedulePictureBox";
            this.CreateEditSchedulePictureBox.Size = new System.Drawing.Size(147, 142);
            this.CreateEditSchedulePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreateEditSchedulePictureBox.TabIndex = 17;
            this.CreateEditSchedulePictureBox.TabStop = false;
            this.CreateEditSchedulePictureBox.Click += new System.EventHandler(this.CreateEditSchedulePictureBox_Click);
            this.CreateEditSchedulePictureBox.MouseLeave += new System.EventHandler(this.CreateEditScheduleMouseLeave);
            this.CreateEditSchedulePictureBox.MouseHover += new System.EventHandler(this.CreateEditScheduleMouseHover);
            // 
            // PayStubPictureBox
            // 
            this.PayStubPictureBox.Image = global::WorkerPunchClock.Properties.Resources.PayStubIcon;
            this.PayStubPictureBox.Location = new System.Drawing.Point(612, 52);
            this.PayStubPictureBox.Name = "PayStubPictureBox";
            this.PayStubPictureBox.Size = new System.Drawing.Size(176, 157);
            this.PayStubPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PayStubPictureBox.TabIndex = 15;
            this.PayStubPictureBox.TabStop = false;
            this.PayStubPictureBox.Click += new System.EventHandler(this.PayStubPictureBox_Click);
            this.PayStubPictureBox.MouseLeave += new System.EventHandler(this.PayStubMouseLeave);
            this.PayStubPictureBox.MouseHover += new System.EventHandler(this.PayStubMouseHover);
            // 
            // RequestTimeOffPictureBox
            // 
            this.RequestTimeOffPictureBox.Image = global::WorkerPunchClock.Properties.Resources.VactionIcon;
            this.RequestTimeOffPictureBox.Location = new System.Drawing.Point(400, 52);
            this.RequestTimeOffPictureBox.Name = "RequestTimeOffPictureBox";
            this.RequestTimeOffPictureBox.Size = new System.Drawing.Size(168, 157);
            this.RequestTimeOffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RequestTimeOffPictureBox.TabIndex = 13;
            this.RequestTimeOffPictureBox.TabStop = false;
            this.RequestTimeOffPictureBox.Click += new System.EventHandler(this.RequestTimeOffPictureBox_Click);
            this.RequestTimeOffPictureBox.MouseLeave += new System.EventHandler(this.RequestTimeOffMouseLeave);
            this.RequestTimeOffPictureBox.MouseHover += new System.EventHandler(this.RequestTimeOffMouseHover);
            // 
            // ClockInOutPictureBox
            // 
            this.ClockInOutPictureBox.Image = global::WorkerPunchClock.Properties.Resources.TimeClockIcon;
            this.ClockInOutPictureBox.Location = new System.Drawing.Point(199, 52);
            this.ClockInOutPictureBox.Name = "ClockInOutPictureBox";
            this.ClockInOutPictureBox.Size = new System.Drawing.Size(162, 157);
            this.ClockInOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClockInOutPictureBox.TabIndex = 11;
            this.ClockInOutPictureBox.TabStop = false;
            this.ClockInOutPictureBox.Click += new System.EventHandler(this.ClockInOutPictureBox_Click);
            this.ClockInOutPictureBox.MouseLeave += new System.EventHandler(this.ClockInOutMouseLeave);
            this.ClockInOutPictureBox.MouseHover += new System.EventHandler(this.ClockInOutMouseHover);
            // 
            // WorkSchedulePictureBox
            // 
            this.WorkSchedulePictureBox.Image = global::WorkerPunchClock.Properties.Resources.CalendarIcon;
            this.WorkSchedulePictureBox.Location = new System.Drawing.Point(12, 52);
            this.WorkSchedulePictureBox.Name = "WorkSchedulePictureBox";
            this.WorkSchedulePictureBox.Size = new System.Drawing.Size(147, 157);
            this.WorkSchedulePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WorkSchedulePictureBox.TabIndex = 9;
            this.WorkSchedulePictureBox.TabStop = false;
            this.WorkSchedulePictureBox.Click += new System.EventHandler(this.WorkSchedulePictureBox_Click);
            this.WorkSchedulePictureBox.MouseLeave += new System.EventHandler(this.WorkScheduleMouseLeave);
            this.WorkSchedulePictureBox.MouseHover += new System.EventHandler(this.WorkScheduleMouseHover);
            // 
            // ApproveDenyTimeOffLabel
            // 
            this.ApproveDenyTimeOffLabel.AutoSize = true;
            this.ApproveDenyTimeOffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveDenyTimeOffLabel.Location = new System.Drawing.Point(614, 407);
            this.ApproveDenyTimeOffLabel.Name = "ApproveDenyTimeOffLabel";
            this.ApproveDenyTimeOffLabel.Size = new System.Drawing.Size(170, 16);
            this.ApproveDenyTimeOffLabel.TabIndex = 24;
            this.ApproveDenyTimeOffLabel.Text = "Approve/Deny Time Off";
            this.ApproveDenyTimeOffLabel.MouseLeave += new System.EventHandler(this.ApproveDenyTimeOffMouseLeave);
            this.ApproveDenyTimeOffLabel.MouseHover += new System.EventHandler(this.ApproveDenyTimeOffMouseHover);
            // 
            // ManagerPageTimer
            // 
            this.ManagerPageTimer.Tick += new System.EventHandler(this.ManagerPageTimer_Tick);
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataMember = "Employees";
            this.EmployeeBindingSource.DataSource = this.workersDataSet;
            // 
            // workersDataSet
            // 
            this.workersDataSet.DataSetName = "WorkersDataSet";
            this.workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ApproveDenyTimeOffLabel);
            this.Controls.Add(this.ApproveDenyTimeOffPictureBox);
            this.Controls.Add(this.ApprovePayStubsLabel);
            this.Controls.Add(this.CreateEditEmployeeLabel);
            this.Controls.Add(this.CreateEditScheduleLabel);
            this.Controls.Add(this.ApprovePayStubsPictureBox);
            this.Controls.Add(this.CreateEditEmployeePictureBox);
            this.Controls.Add(this.CreateEditSchedulePictureBox);
            this.Controls.Add(this.PayStubLabel);
            this.Controls.Add(this.PayStubPictureBox);
            this.Controls.Add(this.RequestTimeOffLabel);
            this.Controls.Add(this.RequestTimeOffPictureBox);
            this.Controls.Add(this.ClockInOutLabel);
            this.Controls.Add(this.ClockInOutPictureBox);
            this.Controls.Add(this.WorkScheduleLabel);
            this.Controls.Add(this.WorkSchedulePictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerMainMenu";
            this.Text = "Manager Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerMainMenuClosing);
            this.Load += new System.EventHandler(this.ManagerMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApproveDenyTimeOffPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovePayStubsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateEditEmployeePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateEditSchedulePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayStubPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestTimeOffPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockInOutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkSchedulePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Splitter NameSplitter;
        private System.Windows.Forms.Label PayStubLabel;
        private System.Windows.Forms.PictureBox PayStubPictureBox;
        private System.Windows.Forms.Label RequestTimeOffLabel;
        private System.Windows.Forms.PictureBox RequestTimeOffPictureBox;
        private System.Windows.Forms.Label ClockInOutLabel;
        private System.Windows.Forms.PictureBox ClockInOutPictureBox;
        private System.Windows.Forms.Label WorkScheduleLabel;
        private System.Windows.Forms.PictureBox WorkSchedulePictureBox;
        private System.Windows.Forms.PictureBox CreateEditSchedulePictureBox;
        private System.Windows.Forms.PictureBox CreateEditEmployeePictureBox;
        private System.Windows.Forms.PictureBox ApprovePayStubsPictureBox;
        private System.Windows.Forms.Label CreateEditScheduleLabel;
        private System.Windows.Forms.Label CreateEditEmployeeLabel;
        private System.Windows.Forms.Label ApprovePayStubsLabel;
        private System.Windows.Forms.PictureBox ApproveDenyTimeOffPictureBox;
        private System.Windows.Forms.Label ApproveDenyTimeOffLabel;
        private System.Windows.Forms.Timer ManagerPageTimer;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private WorkersDataSet workersDataSet;
        private WorkersDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}