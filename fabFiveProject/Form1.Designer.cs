namespace fabFiveProject
{
    partial class Form1
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
            this.testButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.courseListButton = new System.Windows.Forms.Button();
            this.studentScheduleButton = new System.Windows.Forms.Button();
            this.enrollStudentCourseButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(376, 172);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(109, 107);
            this.testButton.TabIndex = 15;
            this.testButton.Text = "SHOW ALL TABLES";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(546, 334);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 67);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // courseListButton
            // 
            this.courseListButton.FlatAppearance.BorderSize = 0;
            this.courseListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.courseListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListButton.Location = new System.Drawing.Point(546, 238);
            this.courseListButton.Name = "courseListButton";
            this.courseListButton.Size = new System.Drawing.Size(121, 70);
            this.courseListButton.TabIndex = 13;
            this.courseListButton.Text = "Who Is In a Course";
            this.courseListButton.UseVisualStyleBackColor = true;
            this.courseListButton.Click += new System.EventHandler(this.courseListButton_Click_1);
            // 
            // studentScheduleButton
            // 
            this.studentScheduleButton.FlatAppearance.BorderSize = 0;
            this.studentScheduleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.studentScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentScheduleButton.Location = new System.Drawing.Point(197, 314);
            this.studentScheduleButton.Name = "studentScheduleButton";
            this.studentScheduleButton.Size = new System.Drawing.Size(119, 111);
            this.studentScheduleButton.TabIndex = 12;
            this.studentScheduleButton.Text = "What Courses a Student Enrolled In";
            this.studentScheduleButton.UseVisualStyleBackColor = true;
            this.studentScheduleButton.Click += new System.EventHandler(this.studentScheduleButton_Click_1);
            // 
            // enrollStudentCourseButton
            // 
            this.enrollStudentCourseButton.FlatAppearance.BorderSize = 0;
            this.enrollStudentCourseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.enrollStudentCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrollStudentCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollStudentCourseButton.Location = new System.Drawing.Point(197, 222);
            this.enrollStudentCourseButton.Name = "enrollStudentCourseButton";
            this.enrollStudentCourseButton.Size = new System.Drawing.Size(119, 86);
            this.enrollStudentCourseButton.TabIndex = 11;
            this.enrollStudentCourseButton.Text = "&Enroll a &Student in a Course";
            this.enrollStudentCourseButton.UseVisualStyleBackColor = true;
            this.enrollStudentCourseButton.Click += new System.EventHandler(this.enrollStudentCourseButton_Click_1);
            // 
            // addCourseButton
            // 
            this.addCourseButton.FlatAppearance.BorderSize = 0;
            this.addCourseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.Location = new System.Drawing.Point(546, 138);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(121, 58);
            this.addCourseButton.TabIndex = 10;
            this.addCourseButton.Text = "&Add a Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click_1);
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.SystemColors.Control;
            this.addStudentButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addStudentButton.FlatAppearance.BorderSize = 0;
            this.addStudentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.Location = new System.Drawing.Point(197, 138);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(119, 58);
            this.addStudentButton.TabIndex = 9;
            this.addStudentButton.Text = "&Add a Student";
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 71);
            this.label1.TabIndex = 8;
            this.label1.Text = "Columbia College Course Tracking System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.courseListButton);
            this.Controls.Add(this.studentScheduleButton);
            this.Controls.Add(this.enrollStudentCourseButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button courseListButton;
        private System.Windows.Forms.Button studentScheduleButton;
        private System.Windows.Forms.Button enrollStudentCourseButton;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label label1;
    }
}

