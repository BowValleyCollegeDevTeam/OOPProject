namespace WorkerPunchClock
{
    partial class ApproveDenyTimeOff
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
            this.TimeOffRequestedPanel = new System.Windows.Forms.Panel();
            this.EmployeeNameComboBox = new System.Windows.Forms.ComboBox();
            this.ApproveTimeOffButton = new System.Windows.Forms.Button();
            this.DenyTimeOffButton = new System.Windows.Forms.Button();
            this.workersDataSet = new WorkerPunchClock.WorkersDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WorkerPunchClock.WorkersDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new WorkerPunchClock.WorkersDataSetTableAdapters.TableAdapterManager();
            this.topInfoBar1 = new WorkerPunchClock.TopInfoBar();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeOffRequestedPanel
            // 
            this.TimeOffRequestedPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeOffRequestedPanel.Location = new System.Drawing.Point(0, 175);
            this.TimeOffRequestedPanel.Name = "TimeOffRequestedPanel";
            this.TimeOffRequestedPanel.Size = new System.Drawing.Size(800, 382);
            this.TimeOffRequestedPanel.TabIndex = 0;
            // 
            // EmployeeNameComboBox
            // 
            this.EmployeeNameComboBox.FormattingEnabled = true;
            this.EmployeeNameComboBox.Location = new System.Drawing.Point(13, 88);
            this.EmployeeNameComboBox.Name = "EmployeeNameComboBox";
            this.EmployeeNameComboBox.Size = new System.Drawing.Size(172, 21);
            this.EmployeeNameComboBox.TabIndex = 2;
            this.EmployeeNameComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeNameComboBox_SelectedIndexChanged);
            // 
            // ApproveTimeOffButton
            // 
            this.ApproveTimeOffButton.Location = new System.Drawing.Point(473, 133);
            this.ApproveTimeOffButton.Name = "ApproveTimeOffButton";
            this.ApproveTimeOffButton.Size = new System.Drawing.Size(75, 23);
            this.ApproveTimeOffButton.TabIndex = 3;
            this.ApproveTimeOffButton.Text = "APPROVE";
            this.ApproveTimeOffButton.UseVisualStyleBackColor = true;
            this.ApproveTimeOffButton.Click += new System.EventHandler(this.ApproveTimeOffButton_Click);
            // 
            // DenyTimeOffButton
            // 
            this.DenyTimeOffButton.Location = new System.Drawing.Point(583, 132);
            this.DenyTimeOffButton.Name = "DenyTimeOffButton";
            this.DenyTimeOffButton.Size = new System.Drawing.Size(75, 23);
            this.DenyTimeOffButton.TabIndex = 4;
            this.DenyTimeOffButton.Text = "DENY";
            this.DenyTimeOffButton.UseVisualStyleBackColor = true;
            this.DenyTimeOffButton.Click += new System.EventHandler(this.DenyTimeOffButton_Click);
            // 
            // workersDataSet
            // 
            this.workersDataSet.DataSetName = "WorkersDataSet";
            this.workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.workersDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WorkerPunchClock.WorkersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // topInfoBar1
            // 
            this.topInfoBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topInfoBar1.Location = new System.Drawing.Point(0, 0);
            this.topInfoBar1.Name = "topInfoBar1";
            this.topInfoBar1.Size = new System.Drawing.Size(800, 35);
            this.topInfoBar1.TabIndex = 1;
            // 
            // ApproveDenyTimeOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.DenyTimeOffButton);
            this.Controls.Add(this.ApproveTimeOffButton);
            this.Controls.Add(this.EmployeeNameComboBox);
            this.Controls.Add(this.topInfoBar1);
            this.Controls.Add(this.TimeOffRequestedPanel);
            this.Name = "ApproveDenyTimeOff";
            this.Text = "ApproveDenyTimeOff";
            this.Load += new System.EventHandler(this.ApproveDenyTimeOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TimeOffRequestedPanel;
        private TopInfoBar topInfoBar1;
        private System.Windows.Forms.ComboBox EmployeeNameComboBox;
        private System.Windows.Forms.Button ApproveTimeOffButton;
        private System.Windows.Forms.Button DenyTimeOffButton;
        private WorkersDataSet workersDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private WorkersDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private WorkersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}