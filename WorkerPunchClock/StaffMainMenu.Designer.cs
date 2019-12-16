namespace WorkerPunchClock
{
    partial class StaffMainMenu
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
            this.WorkScheduleLabel = new System.Windows.Forms.Label();
            this.ClockInOutLabel = new System.Windows.Forms.Label();
            this.RequestTimeOffLabel = new System.Windows.Forms.Label();
            this.PayStubLabel = new System.Windows.Forms.Label();
            this.PayStubPictureBox = new System.Windows.Forms.PictureBox();
            this.RequestTimeOffPictureBox = new System.Windows.Forms.PictureBox();
            this.ClockInOutPictureBox = new System.Windows.Forms.PictureBox();
            this.WorkSchedulePictureBox = new System.Windows.Forms.PictureBox();
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersDataSet = new WorkerPunchClock.WorkersDataSet();
            this.employeesTableAdapter = new WorkerPunchClock.WorkersDataSetTableAdapters.EmployeesTableAdapter();
            this.topInfoBar1 = new WorkerPunchClock.TopInfoBar();
            ((System.ComponentModel.ISupportInitialize)(this.PayStubPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestTimeOffPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockInOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkSchedulePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkScheduleLabel
            // 
            this.WorkScheduleLabel.AutoSize = true;
            this.WorkScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkScheduleLabel.Location = new System.Drawing.Point(22, 215);
            this.WorkScheduleLabel.Name = "WorkScheduleLabel";
            this.WorkScheduleLabel.Size = new System.Drawing.Size(130, 20);
            this.WorkScheduleLabel.TabIndex = 2;
            this.WorkScheduleLabel.Text = "Work Schedule";
            this.WorkScheduleLabel.MouseLeave += new System.EventHandler(this.WorkScheduleMouseLeave);
            this.WorkScheduleLabel.MouseHover += new System.EventHandler(this.WorkScheduleMouseHover);
            // 
            // ClockInOutLabel
            // 
            this.ClockInOutLabel.AutoSize = true;
            this.ClockInOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockInOutLabel.Location = new System.Drawing.Point(229, 215);
            this.ClockInOutLabel.Name = "ClockInOutLabel";
            this.ClockInOutLabel.Size = new System.Drawing.Size(108, 20);
            this.ClockInOutLabel.TabIndex = 4;
            this.ClockInOutLabel.Text = "Clock In/Out";
            this.ClockInOutLabel.MouseLeave += new System.EventHandler(this.ClockInOutMouseLeave);
            this.ClockInOutLabel.MouseHover += new System.EventHandler(this.ClockInOutMouseHover);
            // 
            // RequestTimeOffLabel
            // 
            this.RequestTimeOffLabel.AutoSize = true;
            this.RequestTimeOffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestTimeOffLabel.Location = new System.Drawing.Point(408, 215);
            this.RequestTimeOffLabel.Name = "RequestTimeOffLabel";
            this.RequestTimeOffLabel.Size = new System.Drawing.Size(150, 20);
            this.RequestTimeOffLabel.TabIndex = 6;
            this.RequestTimeOffLabel.Text = "Request Time Off";
            this.RequestTimeOffLabel.MouseLeave += new System.EventHandler(this.RequestTimeOffMouseLeave);
            this.RequestTimeOffLabel.MouseHover += new System.EventHandler(this.RequestTimeOffMouseHover);
            // 
            // PayStubLabel
            // 
            this.PayStubLabel.AutoSize = true;
            this.PayStubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayStubLabel.Location = new System.Drawing.Point(661, 215);
            this.PayStubLabel.Name = "PayStubLabel";
            this.PayStubLabel.Size = new System.Drawing.Size(81, 20);
            this.PayStubLabel.TabIndex = 8;
            this.PayStubLabel.Text = "Pay Stub";
            this.PayStubLabel.MouseLeave += new System.EventHandler(this.PayStubMouseLeave);
            this.PayStubLabel.MouseHover += new System.EventHandler(this.PayStubMouseHover);
            // 
            // PayStubPictureBox
            // 
            this.PayStubPictureBox.Image = global::WorkerPunchClock.Properties.Resources.PayStubIcon;
            this.PayStubPictureBox.Location = new System.Drawing.Point(612, 55);
            this.PayStubPictureBox.Name = "PayStubPictureBox";
            this.PayStubPictureBox.Size = new System.Drawing.Size(176, 157);
            this.PayStubPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PayStubPictureBox.TabIndex = 7;
            this.PayStubPictureBox.TabStop = false;
            this.PayStubPictureBox.Click += new System.EventHandler(this.PayStubPictureBox_Click);
            this.PayStubPictureBox.MouseLeave += new System.EventHandler(this.PayStubMouseLeave);
            this.PayStubPictureBox.MouseHover += new System.EventHandler(this.PayStubMouseHover);
            // 
            // RequestTimeOffPictureBox
            // 
            this.RequestTimeOffPictureBox.Image = global::WorkerPunchClock.Properties.Resources.VactionIcon;
            this.RequestTimeOffPictureBox.Location = new System.Drawing.Point(400, 55);
            this.RequestTimeOffPictureBox.Name = "RequestTimeOffPictureBox";
            this.RequestTimeOffPictureBox.Size = new System.Drawing.Size(168, 157);
            this.RequestTimeOffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RequestTimeOffPictureBox.TabIndex = 5;
            this.RequestTimeOffPictureBox.TabStop = false;
            this.RequestTimeOffPictureBox.Click += new System.EventHandler(this.RequestTimeOffPictureBox_Click);
            this.RequestTimeOffPictureBox.MouseLeave += new System.EventHandler(this.RequestTimeOffMouseLeave);
            this.RequestTimeOffPictureBox.MouseHover += new System.EventHandler(this.RequestTimeOffMouseHover);
            // 
            // ClockInOutPictureBox
            // 
            this.ClockInOutPictureBox.Image = global::WorkerPunchClock.Properties.Resources.TimeClockIcon;
            this.ClockInOutPictureBox.Location = new System.Drawing.Point(199, 55);
            this.ClockInOutPictureBox.Name = "ClockInOutPictureBox";
            this.ClockInOutPictureBox.Size = new System.Drawing.Size(162, 157);
            this.ClockInOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClockInOutPictureBox.TabIndex = 3;
            this.ClockInOutPictureBox.TabStop = false;
            this.ClockInOutPictureBox.Click += new System.EventHandler(this.ClockInOutPictureBox_Click);
            this.ClockInOutPictureBox.MouseLeave += new System.EventHandler(this.ClockInOutMouseLeave);
            this.ClockInOutPictureBox.MouseHover += new System.EventHandler(this.ClockInOutMouseHover);
            // 
            // WorkSchedulePictureBox
            // 
            this.WorkSchedulePictureBox.Image = global::WorkerPunchClock.Properties.Resources.CalendarIcon;
            this.WorkSchedulePictureBox.Location = new System.Drawing.Point(12, 55);
            this.WorkSchedulePictureBox.Name = "WorkSchedulePictureBox";
            this.WorkSchedulePictureBox.Size = new System.Drawing.Size(147, 157);
            this.WorkSchedulePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WorkSchedulePictureBox.TabIndex = 0;
            this.WorkSchedulePictureBox.TabStop = false;
            this.WorkSchedulePictureBox.Click += new System.EventHandler(this.WorkSchedulePictureBox_Click);
            this.WorkSchedulePictureBox.MouseLeave += new System.EventHandler(this.WorkScheduleMouseLeave);
            this.WorkSchedulePictureBox.MouseHover += new System.EventHandler(this.WorkScheduleMouseHover);
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
            // topInfoBar1
            // 
            this.topInfoBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topInfoBar1.Location = new System.Drawing.Point(0, 0);
            this.topInfoBar1.Name = "topInfoBar1";
            this.topInfoBar1.Size = new System.Drawing.Size(800, 35);
            this.topInfoBar1.TabIndex = 9;
            // 
            // StaffMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.topInfoBar1);
            this.Controls.Add(this.PayStubLabel);
            this.Controls.Add(this.PayStubPictureBox);
            this.Controls.Add(this.RequestTimeOffLabel);
            this.Controls.Add(this.RequestTimeOffPictureBox);
            this.Controls.Add(this.ClockInOutLabel);
            this.Controls.Add(this.ClockInOutPictureBox);
            this.Controls.Add(this.WorkScheduleLabel);
            this.Controls.Add(this.WorkSchedulePictureBox);
            this.Name = "StaffMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffMainMenuClosing);
            this.Load += new System.EventHandler(this.StaffMainMenu_Load);
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

        private System.Windows.Forms.PictureBox WorkSchedulePictureBox;
        private System.Windows.Forms.Label WorkScheduleLabel;
        private System.Windows.Forms.PictureBox ClockInOutPictureBox;
        private System.Windows.Forms.Label ClockInOutLabel;
        private System.Windows.Forms.PictureBox RequestTimeOffPictureBox;
        private System.Windows.Forms.Label RequestTimeOffLabel;
        private System.Windows.Forms.PictureBox PayStubPictureBox;
        private System.Windows.Forms.Label PayStubLabel;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private WorkersDataSet workersDataSet;
        private WorkersDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        public TopInfoBar topInfoBar1;
    }
}