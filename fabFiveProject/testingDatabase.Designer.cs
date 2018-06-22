namespace fabFiveProject
{
    partial class testingDatabase
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
            this.resetButton = new System.Windows.Forms.Button();
            this.semesterData = new System.Windows.Forms.DataGridView();
            this.completeData = new System.Windows.Forms.DataGridView();
            this.courseData = new System.Windows.Forms.DataGridView();
            this.studentData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.semesterData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(655, 14);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(151, 36);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "RESET DATABASE";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // semesterData
            // 
            this.semesterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.semesterData.Location = new System.Drawing.Point(725, 368);
            this.semesterData.Name = "semesterData";
            this.semesterData.RowTemplate.Height = 24;
            this.semesterData.Size = new System.Drawing.Size(645, 438);
            this.semesterData.TabIndex = 20;
            // 
            // completeData
            // 
            this.completeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completeData.Location = new System.Drawing.Point(28, 368);
            this.completeData.Name = "completeData";
            this.completeData.RowTemplate.Height = 24;
            this.completeData.Size = new System.Drawing.Size(671, 437);
            this.completeData.TabIndex = 19;
            // 
            // courseData
            // 
            this.courseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseData.Location = new System.Drawing.Point(725, 56);
            this.courseData.Name = "courseData";
            this.courseData.RowTemplate.Height = 24;
            this.courseData.Size = new System.Drawing.Size(645, 285);
            this.courseData.TabIndex = 18;
            // 
            // studentData
            // 
            this.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentData.Location = new System.Drawing.Point(28, 56);
            this.studentData.Name = "studentData";
            this.studentData.RowTemplate.Height = 24;
            this.studentData.Size = new System.Drawing.Size(671, 285);
            this.studentData.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(991, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "semsters_offered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "student_courses_complete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1012, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "student";
            // 
            // testingDatabase
            // 
            this.ClientSize = new System.Drawing.Size(1394, 960);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.semesterData);
            this.Controls.Add(this.completeData);
            this.Controls.Add(this.courseData);
            this.Controls.Add(this.studentData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "testingDatabase";
            this.Text = "Database Test";
            this.Load += new System.EventHandler(this.testingDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.semesterData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridView semesterData;
        private System.Windows.Forms.DataGridView completeData;
        private System.Windows.Forms.DataGridView courseData;
        private System.Windows.Forms.DataGridView studentData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}