using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fabFiveProject
{
    public partial class addNewCourse : Form
    {
        SqlConnection sqlConn = new SqlConnection();
        string connectionString = ConfigurationManager.ConnectionStrings["fabFiveProject.Properties.Settings.StudentTrackerConnectionString"].ConnectionString;

        public addNewCourse()
        {
            InitializeComponent();
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            using (sqlConn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("USE StudentTracker; INSERT INTO course (courseTitle) VALUES (@courseTitle);" +
                "INSERT INTO semesters_offered(semester, courseId) VALUES (@semesterSeason, (SELECT courseID FROM course WHERE " +
                "courseTitle LIKE @courseTitle));", sqlConn))
            {
                sqlConn.Open();
                comd.Parameters.AddWithValue("@courseTitle", courseTitleTextBox.Text);
                comd.Parameters.AddWithValue("@semesterSeason", semesterTextBox.Text);
                comd.ExecuteScalar();
                var result = MessageBox.Show("Course Added!");
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }

        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

