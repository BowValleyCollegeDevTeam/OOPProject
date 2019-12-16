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
            this.topInfoBar1 = new WorkerPunchClock.TopInfoBar();
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
            // topInfoBar1
            // 
            this.topInfoBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topInfoBar1.Location = new System.Drawing.Point(0, 0);
            this.topInfoBar1.Name = "topInfoBar1";
            this.topInfoBar1.Size = new System.Drawing.Size(800, 35);
            this.topInfoBar1.TabIndex = 7;
            // 
            // RequestTimeOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topInfoBar1);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.EndTimeOff);
            this.Controls.Add(this.TitleRequestTimeOff);
            this.Controls.Add(this.StartTimeOff);
            this.Name = "RequestTimeOff";
            this.Text = "RequestTimeOff";
            this.Load += new System.EventHandler(this.RequestTimeOff_Load);
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
        private TopInfoBar topInfoBar1;
    }
}