namespace WorkerPunchClock
{
    partial class ClockInOut
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
            this.ClockInButton = new System.Windows.Forms.Button();
            this.ClockInOutPanel = new System.Windows.Forms.Panel();
            this.clockInClockOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersDataSet = new WorkerPunchClock.WorkersDataSet();
            this.clockInClockOutTableAdapter1 = new WorkerPunchClock.WorkersDataSetTableAdapters.ClockInClockOutTableAdapter();
            this.employeesTableAdapter1 = new WorkerPunchClock.WorkersDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager1 = new WorkerPunchClock.WorkersDataSetTableAdapters.TableAdapterManager();
            this.topInfoBar1 = new WorkerPunchClock.TopInfoBar();
            ((System.ComponentModel.ISupportInitialize)(this.clockInClockOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ClockInButton
            // 
            this.ClockInButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClockInButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClockInButton.FlatAppearance.BorderSize = 0;
            this.ClockInButton.Location = new System.Drawing.Point(298, 41);
            this.ClockInButton.Name = "ClockInButton";
            this.ClockInButton.Size = new System.Drawing.Size(106, 37);
            this.ClockInButton.TabIndex = 1;
            this.ClockInButton.Text = "Clock In";
            this.ClockInButton.UseVisualStyleBackColor = false;
            this.ClockInButton.Click += new System.EventHandler(this.ClockInButton_Click);
            // 
            // ClockInOutPanel
            // 
            this.ClockInOutPanel.AutoScroll = true;
            this.ClockInOutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClockInOutPanel.Location = new System.Drawing.Point(0, 35);
            this.ClockInOutPanel.Name = "ClockInOutPanel";
            this.ClockInOutPanel.Size = new System.Drawing.Size(292, 415);
            this.ClockInOutPanel.TabIndex = 3;
            // 
            // clockInClockOutBindingSource
            // 
            this.clockInClockOutBindingSource.DataMember = "ClockInClockOut";
            this.clockInClockOutBindingSource.DataSource = this.workersDataSet;
            // 
            // workersDataSet
            // 
            this.workersDataSet.DataSetName = "WorkersDataSet";
            this.workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clockInClockOutTableAdapter1
            // 
            this.clockInClockOutTableAdapter1.ClearBeforeFill = true;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClockInClockOutTableAdapter = this.clockInClockOutTableAdapter1;
            this.tableAdapterManager1.EmployeesTableAdapter = this.employeesTableAdapter1;
            this.tableAdapterManager1.PayStubTableAdapter = null;
            this.tableAdapterManager1.RequestTimeOffTableAdapter = null;
            this.tableAdapterManager1.ScheduleTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WorkerPunchClock.WorkersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // topInfoBar1
            // 
            this.topInfoBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topInfoBar1.Location = new System.Drawing.Point(0, 0);
            this.topInfoBar1.Name = "topInfoBar1";
            this.topInfoBar1.Size = new System.Drawing.Size(416, 35);
            this.topInfoBar1.TabIndex = 2;
            // 
            // ClockInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.ClockInOutPanel);
            this.Controls.Add(this.topInfoBar1);
            this.Controls.Add(this.ClockInButton);
            this.Name = "ClockInOut";
            this.Text = "pane";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClockInOutClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClockInOutClosed);
            this.Load += new System.EventHandler(this.ClockInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clockInClockOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private TopMenuBar topMenuBar1;
        private System.Windows.Forms.Button ClockInButton;
        private TopInfoBar topInfoBar1;
        private System.Windows.Forms.Panel ClockInOutPanel;
        private System.Windows.Forms.BindingSource clockInClockOutBindingSource;
        private WorkersDataSet workersDataSet;
        private WorkersDataSetTableAdapters.ClockInClockOutTableAdapter clockInClockOutTableAdapter1;
        private WorkersDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private WorkersDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}