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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.NameSplitter = new System.Windows.Forms.Splitter();
            this.WorkScheduleLabel = new System.Windows.Forms.Label();
            this.TimeTimerTicker = new System.Windows.Forms.Timer(this.components);
            this.ClockInOutLabel = new System.Windows.Forms.Label();
            this.RequestTimeOffLabel = new System.Windows.Forms.Label();
            this.PayStubLabel = new System.Windows.Forms.Label();
            this.PayStubPictureBox = new System.Windows.Forms.PictureBox();
            this.RequestTimeOffPictureBox = new System.Windows.Forms.PictureBox();
            this.ClockInOutPictureBox = new System.Windows.Forms.PictureBox();
            this.WorkSchedulePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayStubPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestTimeOffPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockInOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkSchedulePictureBox)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            // WorkScheduleLabel
            // 
            this.WorkScheduleLabel.AutoSize = true;
            this.WorkScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkScheduleLabel.Location = new System.Drawing.Point(22, 215);
            this.WorkScheduleLabel.Name = "WorkScheduleLabel";
            this.WorkScheduleLabel.Size = new System.Drawing.Size(130, 20);
            this.WorkScheduleLabel.TabIndex = 2;
            this.WorkScheduleLabel.Text = "Work Schedule";
            this.WorkScheduleLabel.MouseEnter += new System.EventHandler(this.WorkScheduleMouseEnter);
            this.WorkScheduleLabel.MouseLeave += new System.EventHandler(this.WorkScheduleMouseLeave);
            // 
            // TimeTimerTicker
            // 
            this.TimeTimerTicker.Tick += new System.EventHandler(this.TimeTimerTicker_Tick);
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
            this.WorkSchedulePictureBox.MouseEnter += new System.EventHandler(this.WorkScheduleMouseEnter);
            this.WorkSchedulePictureBox.MouseLeave += new System.EventHandler(this.WorkScheduleMouseLeave);
            // 
            // StaffMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.PayStubLabel);
            this.Controls.Add(this.PayStubPictureBox);
            this.Controls.Add(this.RequestTimeOffLabel);
            this.Controls.Add(this.RequestTimeOffPictureBox);
            this.Controls.Add(this.ClockInOutLabel);
            this.Controls.Add(this.ClockInOutPictureBox);
            this.Controls.Add(this.WorkScheduleLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WorkSchedulePictureBox);
            this.Name = "StaffMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffMainMenuClosing);
            this.Load += new System.EventHandler(this.StaffMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayStubPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestTimeOffPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockInOutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkSchedulePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WorkSchedulePictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WorkScheduleLabel;
        private System.Windows.Forms.Splitter NameSplitter;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer TimeTimerTicker;
        private System.Windows.Forms.PictureBox ClockInOutPictureBox;
        private System.Windows.Forms.Label ClockInOutLabel;
        private System.Windows.Forms.PictureBox RequestTimeOffPictureBox;
        private System.Windows.Forms.Label RequestTimeOffLabel;
        private System.Windows.Forms.PictureBox PayStubPictureBox;
        private System.Windows.Forms.Label PayStubLabel;
    }
}