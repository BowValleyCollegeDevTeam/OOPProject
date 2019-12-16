namespace WorkerPunchClock
{
    partial class CreateEditSchedule
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.topInfoBar1 = new WorkerPunchClock.TopInfoBar();
            this.nameLabel = new System.Windows.Forms.Label();
            this.empLabel = new System.Windows.Forms.Label();
            this.SelectEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 173);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(800, 277);
            this.listBox1.TabIndex = 0;
            // 
            // topInfoBar1
            // 
            this.topInfoBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topInfoBar1.Location = new System.Drawing.Point(0, 0);
            this.topInfoBar1.Name = "topInfoBar1";
            this.topInfoBar1.Size = new System.Drawing.Size(800, 35);
            this.topInfoBar1.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(105, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "label1";
            // 
            // empLabel
            // 
            this.empLabel.AutoSize = true;
            this.empLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLabel.Location = new System.Drawing.Point(12, 74);
            this.empLabel.Name = "empLabel";
            this.empLabel.Size = new System.Drawing.Size(87, 20);
            this.empLabel.TabIndex = 3;
            this.empLabel.Text = "Employee: ";
            // 
            // SelectEmployeeComboBox
            // 
            this.SelectEmployeeComboBox.FormattingEnabled = true;
            this.SelectEmployeeComboBox.Location = new System.Drawing.Point(13, 42);
            this.SelectEmployeeComboBox.Name = "SelectEmployeeComboBox";
            this.SelectEmployeeComboBox.Size = new System.Drawing.Size(143, 21);
            this.SelectEmployeeComboBox.TabIndex = 5;
            // 
            // CreateEditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectEmployeeComboBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.empLabel);
            this.Controls.Add(this.topInfoBar1);
            this.Controls.Add(this.listBox1);
            this.Name = "CreateEditSchedule";
            this.Text = "CreateEditSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private TopInfoBar topInfoBar1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label empLabel;
        private System.Windows.Forms.ComboBox SelectEmployeeComboBox;
    }
}