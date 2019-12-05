namespace WorkerPunchClock
{
    partial class RequestTimeOff
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
            this.StartTimeOff = new System.Windows.Forms.DateTimePicker();
            this.TitleRequestTimeOff = new System.Windows.Forms.Label();
            this.EndTimeOff = new System.Windows.Forms.DateTimePicker();
            this.Start = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.Label();
            this.Request = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.NameSplitter = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartTimeOff
            // 
            this.StartTimeOff.Location = new System.Drawing.Point(63, 255);
            this.StartTimeOff.Name = "StartTimeOff";
            this.StartTimeOff.Size = new System.Drawing.Size(200, 20);
            this.StartTimeOff.TabIndex = 0;
            this.StartTimeOff.ValueChanged += new System.EventHandler(this.StartTimeOff_ValueChanged);
            // 
            // TitleRequestTimeOff
            // 
            this.TitleRequestTimeOff.AutoSize = true;
            this.TitleRequestTimeOff.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRequestTimeOff.Location = new System.Drawing.Point(310, 37);
            this.TitleRequestTimeOff.Name = "TitleRequestTimeOff";
            this.TitleRequestTimeOff.Size = new System.Drawing.Size(152, 45);
            this.TitleRequestTimeOff.TabIndex = 1;
            this.TitleRequestTimeOff.Text = "Time Off";
            // 
            // EndTimeOff
            // 
            this.EndTimeOff.Location = new System.Drawing.Point(507, 255);
            this.EndTimeOff.Name = "EndTimeOff";
            this.EndTimeOff.Size = new System.Drawing.Size(200, 20);
            this.EndTimeOff.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(70, 160);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(183, 31);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start Time Off";
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.Location = new System.Drawing.Point(521, 160);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(173, 31);
            this.End.TabIndex = 4;
            this.End.Text = "End Time Off";
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(318, 380);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(139, 23);
            this.Request.TabIndex = 6;
            this.Request.Text = "Request Time Off";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Click += new System.EventHandler(this.Request_Click);
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
            this.panel1.TabIndex = 7;
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
            // RequestTimeOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.EndTimeOff);
            this.Controls.Add(this.TitleRequestTimeOff);
            this.Controls.Add(this.StartTimeOff);
            this.Name = "RequestTimeOff";
            this.Text = "RequestTimeOff";
            this.Load += new System.EventHandler(this.RequestTimeOff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartTimeOff;
        private System.Windows.Forms.Label TitleRequestTimeOff;
        private System.Windows.Forms.DateTimePicker EndTimeOff;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label End;
        private System.Windows.Forms.Button Request;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Splitter NameSplitter;
    }
}