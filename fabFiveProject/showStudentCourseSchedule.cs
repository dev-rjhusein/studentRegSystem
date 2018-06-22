using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fabFiveProject
{
    public partial class showStudentCourseSchedule : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["fabFiveProject.Properties.Settings.StudentTrackerConnectionString"].ConnectionString;
        SqlConnection sqlConn = new SqlConnection();

        public showStudentCourseSchedule()
        {
            InitializeComponent();
        }

        private void findButton_Click_1(object sender, EventArgs e)
        {
            /* Fill the listBox with all the courses */
            using (sqlConn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("USE StudentTracker; SELECT courseTitle FROM course WHERE courseId IN" +
                " (SELECT courseId FROM student_courses_complete WHERE studentId = @studentId);", sqlConn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", searchStudentIdTextBox.Text);
                DataTable studentsCoursesTable = new DataTable();
                adapter.Fill(studentsCoursesTable);

                coursesListBox.DisplayMember = "courseTitle";
                coursesListBox.ValueMember = "courseTitle";
                coursesListBox.DataSource = studentsCoursesTable;
            }

            /* return and use the students name */
            using (sqlConn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("USE StudentTracker; SELECT studentName FROM student WHERE studentId = @studentId", sqlConn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", searchStudentIdTextBox.Text);

                sqlConn.Open();
                var result = comd.ExecuteScalar();
                studentNameLabel.Text = result.ToString();

                label5.Text = "List of " + result.ToString() + " 's courses:";
                label5.Visible = true;
            }
        }
    }
}
