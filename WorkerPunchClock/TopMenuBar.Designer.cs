namespace WorkerPunchClock
{
    partial class TopMenuBar
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
            this.TopMenuPanel = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ActiveStatusSplitter = new System.Windows.Forms.Splitter();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ClockSplitter = new System.Windows.Forms.Splitter();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.NameSplitter = new System.Windows.Forms.Splitter();
            this.TimeTimerTicker = new System.Windows.Forms.Timer(this.components);
            this.TopMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenuPanel
            // 
            this.TopMenuPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopMenuPanel.BackColor = System.Drawing.Color.Silver;
            this.TopMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopMenuPanel.Controls.Add(this.StatusLabel);
            this.TopMenuPanel.Controls.Add(this.ActiveStatusSplitter);
            this.TopMenuPanel.Controls.Add(this.TimeLabel);
            this.TopMenuPanel.Controls.Add(this.ClockSplitter);
            this.TopMenuPanel.Controls.Add(this.StaffNameLabel);
            this.TopMenuPanel.Controls.Add(this.NameSplitter);
            this.TopMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.TopMenuPanel.Name = "TopMenuPanel";
            this.TopMenuPanel.Size = new System.Drawing.Size(574, 35);
            this.TopMenuPanel.TabIndex = 2;
            this.TopMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopMenuPanel_Paint);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(305, 8);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(121, 13);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status: Clocked Out";
            this.StatusLabel.TextChanged += new System.EventHandler(this.StatusLabel_TextChanged);
            // 
            // ActiveStatusSplitter
            // 
            this.ActiveStatusSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ActiveStatusSplitter.Location = new System.Drawing.Point(299, 0);
            this.ActiveStatusSplitter.Name = "ActiveStatusSplitter";
            this.ActiveStatusSplitter.Size = new System.Drawing.Size(138, 33);
            this.ActiveStatusSplitter.TabIndex = 4;
            this.ActiveStatusSplitter.TabStop = false;
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
            // ClockSplitter
            // 
            this.ClockSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClockSplitter.Enabled = false;
            this.ClockSplitter.Location = new System.Drawing.Point(137, 0);
            this.ClockSplitter.Name = "ClockSplitter";
            this.ClockSplitter.Size = new System.Drawing.Size(162, 33);
            this.ClockSplitter.TabIndex = 2;
            this.ClockSplitter.TabStop = false;
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
            this.NameSplitter.Size = new System.Drawing.Size(137, 33);
            this.NameSplitter.TabIndex = 0;
            this.NameSplitter.TabStop = false;
            // 
            // TimeTimerTicker
            // 
            this.TimeTimerTicker.Tick += new System.EventHandler(this.TimeTimerTicker_Tick);
            // 
            // TopMenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TopMenuPanel);
            this.Name = "TopMenuBar";
            this.Size = new System.Drawing.Size(574, 35);
            this.TopMenuPanel.ResumeLayout(false);
            this.TopMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopMenuPanel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Splitter ClockSplitter;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Splitter NameSplitter;
        private System.Windows.Forms.Timer TimeTimerTicker;
        private System.Windows.Forms.Splitter ActiveStatusSplitter;
        public System.Windows.Forms.Label StatusLabel;
    }
}
