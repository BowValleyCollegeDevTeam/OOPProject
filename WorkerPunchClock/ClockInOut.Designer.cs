﻿namespace WorkerPunchClock
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
            this.ClockInOutButton = new System.Windows.Forms.Button();
            this.ClockInOutPanel = new System.Windows.Forms.Panel();
            this.topMenuBar1 = new WorkerPunchClock.TopMenuBar();
            this.SuspendLayout();
            // 
            // ClockInOutButton
            // 
            this.ClockInOutButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClockInOutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClockInOutButton.FlatAppearance.BorderSize = 0;
            this.ClockInOutButton.Location = new System.Drawing.Point(12, 41);
            this.ClockInOutButton.Name = "ClockInOutButton";
            this.ClockInOutButton.Size = new System.Drawing.Size(106, 37);
            this.ClockInOutButton.TabIndex = 1;
            this.ClockInOutButton.Text = "Clock In";
            this.ClockInOutButton.UseVisualStyleBackColor = false;
            this.ClockInOutButton.Click += new System.EventHandler(this.ClockInOutButton_Click);
            // 
            // ClockInOutPanel
            // 
            this.ClockInOutPanel.AutoScroll = true;
            this.ClockInOutPanel.Location = new System.Drawing.Point(0, 89);
            this.ClockInOutPanel.Name = "ClockInOutPanel";
            this.ClockInOutPanel.Size = new System.Drawing.Size(440, 361);
            this.ClockInOutPanel.TabIndex = 2;
            // 
            // topMenuBar1
            // 
            this.topMenuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topMenuBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenuBar1.Location = new System.Drawing.Point(0, 0);
            this.topMenuBar1.Name = "topMenuBar1";
            this.topMenuBar1.Size = new System.Drawing.Size(440, 35);
            this.topMenuBar1.TabIndex = 0;
            // 
            // ClockInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.ClockInOutPanel);
            this.Controls.Add(this.ClockInOutButton);
            this.Controls.Add(this.topMenuBar1);
            this.Name = "ClockInOut";
            this.Text = "ClockInOut";
            this.Load += new System.EventHandler(this.ClockInOut_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TopMenuBar topMenuBar1;
        private System.Windows.Forms.Button ClockInOutButton;
        private System.Windows.Forms.Panel ClockInOutPanel;
    }
}