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
            this.payStubListBox = new System.Windows.Forms.ListBox();
            this.topInfoBar1 = new WorkerPunchClock.TopInfoBar();
            this.payStubLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // payStubListBox
            // 
            this.payStubListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.payStubListBox.FormattingEnabled = true;
            this.payStubListBox.Location = new System.Drawing.Point(0, 95);
            this.payStubListBox.Name = "payStubListBox";
            this.payStubListBox.Size = new System.Drawing.Size(800, 355);
            this.payStubListBox.TabIndex = 7;
            // 
            // topInfoBar1
            // 
            this.topInfoBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topInfoBar1.Location = new System.Drawing.Point(0, 0);
            this.topInfoBar1.Name = "topInfoBar1";
            this.topInfoBar1.Size = new System.Drawing.Size(800, 35);
            this.topInfoBar1.TabIndex = 6;
            // 
            // payStubLabel
            // 
            this.payStubLabel.AutoSize = true;
            this.payStubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payStubLabel.Location = new System.Drawing.Point(-5, 55);
            this.payStubLabel.Name = "payStubLabel";
            this.payStubLabel.Size = new System.Drawing.Size(175, 25);
            this.payStubLabel.TabIndex = 8;
            this.payStubLabel.Text = "Paystub History: ";
            // 
            // PayStub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.payStubLabel);
            this.Controls.Add(this.payStubListBox);
            this.Controls.Add(this.topInfoBar1);
            this.Name = "PayStub";
            this.Text = "PayStub";
            this.Load += new System.EventHandler(this.PayStub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TopInfoBar topInfoBar1;
        private System.Windows.Forms.ListBox payStubListBox;
        private System.Windows.Forms.Label payStubLabel;
    }
}