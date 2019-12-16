namespace WorkerPunchClock
{
    partial class TopInfoBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.NameSplitter = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.TimeTimerTicker = new System.Windows.Forms.Timer(this.components);
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersDataSet = new WorkerPunchClock.WorkersDataSet();
            this.employeesTableAdapter = new WorkerPunchClock.WorkersDataSetTableAdapters.EmployeesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.StaffNameLabel);
            this.panel1.Controls.Add(this.NameSplitter);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 35);
            this.panel1.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(547, 10);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(121, 13);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status: Clocked Out";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(409, 10);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(122, 13);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "00/00/0000 0:00:00";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(404, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(137, 33);
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
            this.NameSplitter.Size = new System.Drawing.Size(142, 33);
            this.NameSplitter.TabIndex = 0;
            this.NameSplitter.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(541, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(135, 33);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // TimeTimerTicker
            // 
            this.TimeTimerTicker.Tick += new System.EventHandler(this.TimeTimerTicker_Tick);
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
            // TopInfoBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TopInfoBar";
            this.Size = new System.Drawing.Size(678, 35);
            this.Load += new System.EventHandler(this.TopInfoBar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter NameSplitter;
        private System.Windows.Forms.Timer TimeTimerTicker;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private WorkersDataSet workersDataSet;
        private WorkersDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Splitter splitter2;
    }
}
