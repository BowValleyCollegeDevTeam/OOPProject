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
            this.RequestTimeOffMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestTimeOffMainMenuButton
            // 
            this.RequestTimeOffMainMenuButton.Location = new System.Drawing.Point(698, 415);
            this.RequestTimeOffMainMenuButton.Name = "RequestTimeOffMainMenuButton";
            this.RequestTimeOffMainMenuButton.Size = new System.Drawing.Size(90, 23);
            this.RequestTimeOffMainMenuButton.TabIndex = 0;
            this.RequestTimeOffMainMenuButton.Text = "Main Menu";
            this.RequestTimeOffMainMenuButton.UseVisualStyleBackColor = true;
            this.RequestTimeOffMainMenuButton.Click += new System.EventHandler(this.RequestTimeOffMainMenuButton_Click);
            // 
            // RequestTimeOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RequestTimeOffMainMenuButton);
            this.Name = "RequestTimeOff";
            this.Text = "RequestTimeOff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RequestTimeOffMainMenuButton;
    }
}