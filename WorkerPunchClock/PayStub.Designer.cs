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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.NameSplitter = new System.Windows.Forms.Splitter();
            this.payStubTextBox = new System.Windows.Forms.RichTextBox();
            this.payStubComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.StaffNameLabel);
            this.panel1.Controls.Add(this.NameSplitter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 3;
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
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(137, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(162, 32);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
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
            this.NameSplitter.Size = new System.Drawing.Size(137, 32);
            this.NameSplitter.TabIndex = 0;
            this.NameSplitter.TabStop = false;
            // 
            // payStubTextBox
            // 
            this.payStubTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.payStubTextBox.Location = new System.Drawing.Point(0, 111);
            this.payStubTextBox.Name = "payStubTextBox";
            this.payStubTextBox.Size = new System.Drawing.Size(800, 339);
            this.payStubTextBox.TabIndex = 4;
            this.payStubTextBox.Text = "";
            // 
            // payStubComboBox
            // 
            this.payStubComboBox.FormattingEnabled = true;
            this.payStubComboBox.Items.AddRange(new object[] {
            "Select Pay Period"});
            this.payStubComboBox.Location = new System.Drawing.Point(1, 40);
            this.payStubComboBox.Name = "payStubComboBox";
            this.payStubComboBox.Size = new System.Drawing.Size(137, 21);
            this.payStubComboBox.TabIndex = 5;
            this.payStubComboBox.SelectedIndexChanged += new System.EventHandler(this.payStubComboBox_SelectedIndexChanged);
            // 
            // PayStub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.payStubComboBox);
            this.Controls.Add(this.payStubTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "PayStub";
            this.Text = "PayStub";
            this.Load += new System.EventHandler(this.PayStub_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Splitter NameSplitter;
        private System.Windows.Forms.RichTextBox payStubTextBox;
        private System.Windows.Forms.ComboBox payStubComboBox;
    }
}