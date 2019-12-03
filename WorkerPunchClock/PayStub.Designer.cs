namespace WorkerPunchClock
{
    partial class PayStub
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
            this.PayStubMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PayStubMainMenuButton
            // 
            this.PayStubMainMenuButton.Location = new System.Drawing.Point(697, 415);
            this.PayStubMainMenuButton.Name = "PayStubMainMenuButton";
            this.PayStubMainMenuButton.Size = new System.Drawing.Size(91, 23);
            this.PayStubMainMenuButton.TabIndex = 0;
            this.PayStubMainMenuButton.Text = "Main Menu";
            this.PayStubMainMenuButton.UseVisualStyleBackColor = true;
            this.PayStubMainMenuButton.Click += new System.EventHandler(this.PayStubMainMenuButton_Click);
            // 
            // PayStub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PayStubMainMenuButton);
            this.Name = "PayStub";
            this.Text = "PayStub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PayStubMainMenuButton;
    }
}