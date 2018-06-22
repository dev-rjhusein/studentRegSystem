namespace fabFiveProject
{
    partial class showStudentCourseSchedule
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
            this.label5 = new System.Windows.Forms.Label();
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.searchStudentIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 7;
            this.label5.Visible = false;
            // 
            // coursesListBox
            // 
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.ItemHeight = 16;
            this.coursesListBox.Location = new System.Drawing.Point(453, 71);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(324, 340);
            this.coursesListBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentNameLabel);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Controls.Add(this.searchStudentIdTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentNameLabel.Location = new System.Drawing.Point(174, 111);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(2, 19);
            this.studentNameLabel.TabIndex = 4;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(287, 54);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(84, 29);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "&Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click_1);
            // 
            // searchStudentIdTextBox
            // 
            this.searchStudentIdTextBox.Location = new System.Drawing.Point(59, 57);
            this.searchStudentIdTextBox.Name = "searchStudentIdTextBox";
            this.searchStudentIdTextBox.Size = new System.Drawing.Size(212, 22);
            this.searchStudentIdTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // showStudentCourseSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.coursesListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "showStudentCourseSchedule";
            this.Text = "showStudentCourseSchedule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox searchStudentIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}