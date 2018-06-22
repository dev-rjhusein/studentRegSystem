namespace fabFiveProject
{
    partial class showStudentsInCourse
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
            this.closeButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.courseDataGroupBox = new System.Windows.Forms.GroupBox();
            this.courseTitleLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.courseDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(331, 411);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(140, 39);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Cl&ose";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(119, 199);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(376, 19);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "All Students Enrolled In This Course:";
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 16;
            this.studentListBox.Location = new System.Drawing.Point(119, 238);
            this.studentListBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(561, 164);
            this.studentListBox.TabIndex = 8;
            // 
            // courseDataGroupBox
            // 
            this.courseDataGroupBox.Controls.Add(this.courseTitleLabel);
            this.courseDataGroupBox.Controls.Add(this.findButton);
            this.courseDataGroupBox.Controls.Add(this.courseIDTextBox);
            this.courseDataGroupBox.Controls.Add(this.textBox2);
            this.courseDataGroupBox.Controls.Add(this.textBox1);
            this.courseDataGroupBox.Location = new System.Drawing.Point(119, 1);
            this.courseDataGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.courseDataGroupBox.Name = "courseDataGroupBox";
            this.courseDataGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.courseDataGroupBox.Size = new System.Drawing.Size(563, 175);
            this.courseDataGroupBox.TabIndex = 6;
            this.courseDataGroupBox.TabStop = false;
            this.courseDataGroupBox.Text = "Course Data";
            // 
            // courseTitleLabel
            // 
            this.courseTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.courseTitleLabel.Location = new System.Drawing.Point(196, 124);
            this.courseTitleLabel.Name = "courseTitleLabel";
            this.courseTitleLabel.Size = new System.Drawing.Size(329, 28);
            this.courseTitleLabel.TabIndex = 3;
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(413, 53);
            this.findButton.Margin = new System.Windows.Forms.Padding(4);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(112, 28);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "&Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click_1);
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.Location = new System.Drawing.Point(196, 53);
            this.courseIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.Size = new System.Drawing.Size(179, 22);
            this.courseIDTextBox.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(39, 123);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 19);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Course Title:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Course ID:";
            // 
            // showStudentsInCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.courseDataGroupBox);
            this.Name = "showStudentsInCourse";
            this.Text = "showStudentsInCourse";
            this.courseDataGroupBox.ResumeLayout(false);
            this.courseDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.GroupBox courseDataGroupBox;
        private System.Windows.Forms.Label courseTitleLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}