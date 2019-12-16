namespace WorkerPunchClock
{
    partial class ApprovePayStubs
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
            this.EmployeeNameComboBox = new System.Windows.Forms.ComboBox();
            this.PayPeriodComboBox = new System.Windows.Forms.ComboBox();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.PaystubListBox = new System.Windows.Forms.ListBox();
            this.topInfoBar1 = new WorkerPunchClock.TopInfoBar();
            this.SuspendLayout();
            // 
            // EmployeeNameComboBox
            // 
            this.EmployeeNameComboBox.FormattingEnabled = true;
            this.EmployeeNameComboBox.Location = new System.Drawing.Point(12, 38);
            this.EmployeeNameComboBox.Name = "EmployeeNameComboBox";
            this.EmployeeNameComboBox.Size = new System.Drawing.Size(147, 21);
            this.EmployeeNameComboBox.TabIndex = 1;
            this.EmployeeNameComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeNameComboBox_SelectedIndexChanged);
            // 
            // PayPeriodComboBox
            // 
            this.PayPeriodComboBox.FormattingEnabled = true;
            this.PayPeriodComboBox.Location = new System.Drawing.Point(12, 65);
            this.PayPeriodComboBox.Name = "PayPeriodComboBox";
            this.PayPeriodComboBox.Size = new System.Drawing.Size(365, 21);
            this.PayPeriodComboBox.TabIndex = 2;
            this.PayPeriodComboBox.SelectedIndexChanged += new System.EventHandler(this.PayPeriodComboBox_SelectedIndexChanged);
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(558, 54);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(100, 40);
            this.ApproveButton.TabIndex = 3;
            this.ApproveButton.Text = "APPROVE";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);
            // 
            // PaystubListBox
            // 
            this.PaystubListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaystubListBox.FormattingEnabled = true;
            this.PaystubListBox.Location = new System.Drawing.Point(0, 160);
            this.PaystubListBox.Name = "PaystubListBox";
            this.PaystubListBox.Size = new System.Drawing.Size(800, 290);
            this.PaystubListBox.TabIndex = 5;
            // 
            // topInfoBar1
            // 
            this.topInfoBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topInfoBar1.Location = new System.Drawing.Point(0, 0);
            this.topInfoBar1.Name = "topInfoBar1";
            this.topInfoBar1.Size = new System.Drawing.Size(800, 35);
            this.topInfoBar1.TabIndex = 4;
            // 
            // ApprovePayStubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PaystubListBox);
            this.Controls.Add(this.topInfoBar1);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.PayPeriodComboBox);
            this.Controls.Add(this.EmployeeNameComboBox);
            this.Name = "ApprovePayStubs";
            this.Text = "ApprovePayStubs";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox EmployeeNameComboBox;
        private System.Windows.Forms.ComboBox PayPeriodComboBox;
        private System.Windows.Forms.Button ApproveButton;
        private TopInfoBar topInfoBar1;
        private System.Windows.Forms.ListBox PaystubListBox;
    }
}