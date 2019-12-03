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
            this.ClockInOutMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClockInOutMainMenuButton
            // 
            this.ClockInOutMainMenuButton.Location = new System.Drawing.Point(704, 415);
            this.ClockInOutMainMenuButton.Name = "ClockInOutMainMenuButton";
            this.ClockInOutMainMenuButton.Size = new System.Drawing.Size(84, 23);
            this.ClockInOutMainMenuButton.TabIndex = 0;
            this.ClockInOutMainMenuButton.Text = "Main Menu";
            this.ClockInOutMainMenuButton.UseVisualStyleBackColor = true;
            this.ClockInOutMainMenuButton.Click += new System.EventHandler(this.ClockInOutMainMenuButton_Click);
            // 
            // ClockInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClockInOutMainMenuButton);
            this.Name = "ClockInOut";
            this.Text = "ClockInOut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClockInOutMainMenuButton;
    }
}