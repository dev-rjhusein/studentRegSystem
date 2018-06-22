using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fabFiveProject
{
    public partial class showStudentsInCourse : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["fabFiveProject.Properties.Settings.StudentTrackerConnectionString"].ConnectionString;
        SqlConnection sqlConn;

        public showStudentsInCourse()
        {
            InitializeComponent();
        }

        private void findButton_Click_1(object sender, EventArgs e)
        {
            /* */
            using (sqlConn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT studentName FROM student WHERE studentId IN (SELECT studentId FROM student_courses_complete WHERE"
                + " courseId = @courseId);", sqlConn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@courseId", courseIDTextBox.Text);
                DataTable coursesTakenTable = new DataTable();
                adapter.Fill(coursesTakenTable);

                if (coursesTakenTable.Rows.Count < 1)
                {
                    courseTitleLabel.Text = "No Courses Found";
                }
                else
                {
                    /* Some where in here there needs to be a way to change courstTitleLabel.*/
                    studentListBox.DisplayMember = "studentName";
                    studentListBox.ValueMember = "studentName";
                    studentListBox.DataSource = coursesTakenTable;
                }
            }

            /* Set the Course Title*/
            using (sqlConn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT courseTitle FROM course WHERE courseId = @courseId", sqlConn))
            {
                comd.Parameters.AddWithValue("@courseId", courseIDTextBox.Text);
                sqlConn.Open();
                var result = comd.ExecuteScalar().ToString();
                courseTitleLabel.Text = result;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
