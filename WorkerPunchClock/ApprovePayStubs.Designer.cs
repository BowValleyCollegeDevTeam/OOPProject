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
            this.PayStubPanel = new System.Windows.Forms.Panel();
            this.EmployeeNameComboBox = new System.Windows.Forms.ComboBox();
            this.PayPeriodComboBox = new System.Windows.Forms.ComboBox();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.topInfoBar1 = new WorkerPunchClock.TopInfoBar();
            this.SuspendLayout();
            // 
            // PayStubPanel
            // 
            this.PayStubPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PayStubPanel.Location = new System.Drawing.Point(0, 120);
            this.PayStubPanel.Name = "PayStubPanel";
            this.PayStubPanel.Size = new System.Drawing.Size(800, 330);
            this.PayStubPanel.TabIndex = 0;
            // 
            // EmployeeNameComboBox
            // 
            this.EmployeeNameComboBox.FormattingEnabled = true;
            this.EmployeeNameComboBox.Location = new System.Drawing.Point(12, 38);
            this.EmployeeNameComboBox.Name = "EmployeeNameComboBox";
            this.EmployeeNameComboBox.Size = new System.Drawing.Size(147, 21);
            this.EmployeeNameComboBox.TabIndex = 1;
            // 
            // PayPeriodComboBox
            // 
            this.PayPeriodComboBox.FormattingEnabled = true;
            this.PayPeriodComboBox.Location = new System.Drawing.Point(12, 65);
            this.PayPeriodComboBox.Name = "PayPeriodComboBox";
            this.PayPeriodComboBox.Size = new System.Drawing.Size(147, 21);
            this.PayPeriodComboBox.TabIndex = 2;
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(558, 54);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(100, 40);
            this.ApproveButton.TabIndex = 3;
            this.ApproveButton.Text = "APPROVE";
            this.ApproveButton.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.topInfoBar1);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.PayPeriodComboBox);
            this.Controls.Add(this.EmployeeNameComboBox);
            this.Controls.Add(this.PayStubPanel);
            this.Name = "ApprovePayStubs";
            this.Text = "ApprovePayStubs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PayStubPanel;
        private System.Windows.Forms.ComboBox EmployeeNameComboBox;
        private System.Windows.Forms.ComboBox PayPeriodComboBox;
        private System.Windows.Forms.Button ApproveButton;
        private TopInfoBar topInfoBar1;
    }
}