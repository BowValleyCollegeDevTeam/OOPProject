namespace WorkerPunchClock
{
    partial class CreateEditSchedule
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
            this.topInfoBar1 = new WorkerPunchClock.TopInfoBar();
            this.nameLabel = new System.Windows.Forms.Label();
            this.empLabel = new System.Windows.Forms.Label();
            this.SelectEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.startTimetxtbx = new System.Windows.Forms.TextBox();
            this.endTimetxtbx = new System.Windows.Forms.TextBox();
            this.startTimelbl = new System.Windows.Forms.Label();
            this.endTimelbl = new System.Windows.Forms.Label();
            this.scheduleSubmitbtn = new System.Windows.Forms.Button();
            this.enterTimebtn = new System.Windows.Forms.Button();
            this.datelbl = new System.Windows.Forms.Label();
            this.datetxtbx = new System.Windows.Forms.TextBox();
            this.newEditcmb = new System.Windows.Forms.ComboBox();
            this.selectEmployeelbl = new System.Windows.Forms.Label();
            this.newEditlbl = new System.Windows.Forms.Label();
            this.schedulelstbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // topInfoBar1
            // 
            this.topInfoBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topInfoBar1.Location = new System.Drawing.Point(0, 0);
            this.topInfoBar1.Name = "topInfoBar1";
            this.topInfoBar1.Size = new System.Drawing.Size(588, 35);
            this.topInfoBar1.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(32, 164);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 4;
            // 
            // empLabel
            // 
            this.empLabel.AutoSize = true;
            this.empLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLabel.Location = new System.Drawing.Point(32, 133);
            this.empLabel.Name = "empLabel";
            this.empLabel.Size = new System.Drawing.Size(87, 20);
            this.empLabel.TabIndex = 3;
            this.empLabel.Text = "Employee: ";
            // 
            // SelectEmployeeComboBox
            // 
            this.SelectEmployeeComboBox.FormattingEnabled = true;
            this.SelectEmployeeComboBox.Location = new System.Drawing.Point(12, 59);
            this.SelectEmployeeComboBox.Name = "SelectEmployeeComboBox";
            this.SelectEmployeeComboBox.Size = new System.Drawing.Size(143, 21);
            this.SelectEmployeeComboBox.TabIndex = 5;
            this.SelectEmployeeComboBox.SelectedValueChanged += new System.EventHandler(this.SelectEmployeeComboBox_SelectedValueChanged);
            // 
            // startTimetxtbx
            // 
            this.startTimetxtbx.Location = new System.Drawing.Point(99, 217);
            this.startTimetxtbx.Name = "startTimetxtbx";
            this.startTimetxtbx.Size = new System.Drawing.Size(100, 20);
            this.startTimetxtbx.TabIndex = 7;
            // 
            // endTimetxtbx
            // 
            this.endTimetxtbx.Location = new System.Drawing.Point(99, 253);
            this.endTimetxtbx.Name = "endTimetxtbx";
            this.endTimetxtbx.Size = new System.Drawing.Size(100, 20);
            this.endTimetxtbx.TabIndex = 8;
            // 
            // startTimelbl
            // 
            this.startTimelbl.AutoSize = true;
            this.startTimelbl.Location = new System.Drawing.Point(10, 220);
            this.startTimelbl.Name = "startTimelbl";
            this.startTimelbl.Size = new System.Drawing.Size(55, 13);
            this.startTimelbl.TabIndex = 9;
            this.startTimelbl.Text = "Start Time";
            // 
            // endTimelbl
            // 
            this.endTimelbl.AutoSize = true;
            this.endTimelbl.Location = new System.Drawing.Point(13, 256);
            this.endTimelbl.Name = "endTimelbl";
            this.endTimelbl.Size = new System.Drawing.Size(52, 13);
            this.endTimelbl.TabIndex = 10;
            this.endTimelbl.Text = "End Time";
            // 
            // scheduleSubmitbtn
            // 
            this.scheduleSubmitbtn.Location = new System.Drawing.Point(462, 396);
            this.scheduleSubmitbtn.Name = "scheduleSubmitbtn";
            this.scheduleSubmitbtn.Size = new System.Drawing.Size(108, 23);
            this.scheduleSubmitbtn.TabIndex = 11;
            this.scheduleSubmitbtn.Text = "Submit Schedule";
            this.scheduleSubmitbtn.UseVisualStyleBackColor = true;
            this.scheduleSubmitbtn.Click += new System.EventHandler(this.scheduleSubmitbtn_Click);
            // 
            // enterTimebtn
            // 
            this.enterTimebtn.Location = new System.Drawing.Point(91, 294);
            this.enterTimebtn.Name = "enterTimebtn";
            this.enterTimebtn.Size = new System.Drawing.Size(108, 23);
            this.enterTimebtn.TabIndex = 12;
            this.enterTimebtn.Text = "Enter Date/Time";
            this.enterTimebtn.UseVisualStyleBackColor = true;
            this.enterTimebtn.Click += new System.EventHandler(this.enterTimebtn_Click);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(10, 191);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(30, 13);
            this.datelbl.TabIndex = 13;
            this.datelbl.Text = "Date";
            // 
            // datetxtbx
            // 
            this.datetxtbx.Location = new System.Drawing.Point(99, 184);
            this.datetxtbx.Name = "datetxtbx";
            this.datetxtbx.Size = new System.Drawing.Size(100, 20);
            this.datetxtbx.TabIndex = 14;
            // 
            // newEditcmb
            // 
            this.newEditcmb.FormattingEnabled = true;
            this.newEditcmb.Location = new System.Drawing.Point(12, 96);
            this.newEditcmb.Name = "newEditcmb";
            this.newEditcmb.Size = new System.Drawing.Size(143, 21);
            this.newEditcmb.TabIndex = 15;
            this.newEditcmb.SelectedIndexChanged += new System.EventHandler(this.newEditcmb_SelectedIndexChanged);
            // 
            // selectEmployeelbl
            // 
            this.selectEmployeelbl.AutoSize = true;
            this.selectEmployeelbl.Location = new System.Drawing.Point(12, 42);
            this.selectEmployeelbl.Name = "selectEmployeelbl";
            this.selectEmployeelbl.Size = new System.Drawing.Size(86, 13);
            this.selectEmployeelbl.TabIndex = 16;
            this.selectEmployeelbl.Text = "Select Employee";
            // 
            // newEditlbl
            // 
            this.newEditlbl.AutoSize = true;
            this.newEditlbl.Location = new System.Drawing.Point(13, 83);
            this.newEditlbl.Name = "newEditlbl";
            this.newEditlbl.Size = new System.Drawing.Size(62, 13);
            this.newEditlbl.TabIndex = 17;
            this.newEditlbl.Text = "Edit or New";
            // 
            // schedulelstbx
            // 
            this.schedulelstbx.FormattingEnabled = true;
            this.schedulelstbx.Location = new System.Drawing.Point(260, 42);
            this.schedulelstbx.Name = "schedulelstbx";
            this.schedulelstbx.Size = new System.Drawing.Size(316, 342);
            this.schedulelstbx.TabIndex = 18;
            this.schedulelstbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.schedulelstbx_MouseClick);
            // 
            // CreateEditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.schedulelstbx);
            this.Controls.Add(this.newEditlbl);
            this.Controls.Add(this.selectEmployeelbl);
            this.Controls.Add(this.newEditcmb);
            this.Controls.Add(this.datetxtbx);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.enterTimebtn);
            this.Controls.Add(this.scheduleSubmitbtn);
            this.Controls.Add(this.endTimelbl);
            this.Controls.Add(this.startTimelbl);
            this.Controls.Add(this.endTimetxtbx);
            this.Controls.Add(this.startTimetxtbx);
            this.Controls.Add(this.SelectEmployeeComboBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.empLabel);
            this.Controls.Add(this.topInfoBar1);
            this.Name = "CreateEditSchedule";
            this.Text = "CreateEditSchedule";
            this.Load += new System.EventHandler(this.CreateEditSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TopInfoBar topInfoBar1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label empLabel;
        private System.Windows.Forms.ComboBox SelectEmployeeComboBox;
        private System.Windows.Forms.TextBox startTimetxtbx;
        private System.Windows.Forms.TextBox endTimetxtbx;
        private System.Windows.Forms.Label startTimelbl;
        private System.Windows.Forms.Label endTimelbl;
        private System.Windows.Forms.Button scheduleSubmitbtn;
        private System.Windows.Forms.Button enterTimebtn;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.TextBox datetxtbx;
        private System.Windows.Forms.ComboBox newEditcmb;
        private System.Windows.Forms.Label selectEmployeelbl;
        private System.Windows.Forms.Label newEditlbl;
        private System.Windows.Forms.ListBox schedulelstbx;
    }
}