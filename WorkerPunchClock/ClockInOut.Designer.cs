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
            //this.topMenuBar1 = new WorkerPunchClock.TopMenuBar();
            this.ClockInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topMenuBar1
            // 
            //this.topMenuBar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.topMenuBar1.Dock = System.Windows.Forms.DockStyle.Top;
            //this.topMenuBar1.Location = new System.Drawing.Point(0, 0);
            //this.topMenuBar1.Name = "topMenuBar1";
            //this.topMenuBar1.Size = new System.Drawing.Size(800, 35);
            //this.topMenuBar1.TabIndex = 0;
            // 
            // ClockInButton
            // 
            this.ClockInButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClockInButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClockInButton.FlatAppearance.BorderSize = 0;
            this.ClockInButton.Location = new System.Drawing.Point(338, 41);
            this.ClockInButton.Name = "ClockInButton";
            this.ClockInButton.Size = new System.Drawing.Size(106, 37);
            this.ClockInButton.TabIndex = 1;
            this.ClockInButton.Text = "Clock In";
            this.ClockInButton.UseVisualStyleBackColor = false;
            this.ClockInButton.Click += new System.EventHandler(this.ClockInButton_Click);
            // 
            // ClockInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClockInButton);
            //this.Controls.Add(this.topMenuBar1);
            this.Name = "ClockInOut";
            this.Text = "ClockInOut";
            this.ResumeLayout(false);

        }

        #endregion

        //private TopMenuBar topMenuBar1;
        private System.Windows.Forms.Button ClockInButton;
    }
}