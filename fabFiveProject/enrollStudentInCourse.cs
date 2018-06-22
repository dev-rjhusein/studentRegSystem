using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fabFiveProject
{
    public partial class enrollStudentInCourse : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["fabFiveProject.Properties.Settings.StudentTrackerConnectionString"].ConnectionString;
        SqlConnection sqlConn = new SqlConnection();

        public enrollStudentInCourse()
        {
            InitializeComponent();
        }

        private void enrollButton_Click_1(object sender, EventArgs e)
        {
            using (sqlConn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("USE StudentTracker; INSERT INTO student_courses_complete(studentId, courseID)" +
                " VALUES (@student, @course)", sqlConn))
            {
                comd.Parameters.AddWithValue("@student", selectAStudentComboBox.SelectedValue);
                comd.Parameters.AddWithValue("@course", selectACourseComboBox.SelectedValue);

                sqlConn.Open();
                comd.ExecuteScalar();
                Close();
            }
        }

        private void enrollStudentInCourse_Load(object sender, EventArgs e)
        {
            using (sqlConn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("USE StudentTracker; SELECT * FROM student;", sqlConn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable studentNameTable = new DataTable();
                adapter.Fill(studentNameTable);
                selectAStudentComboBox.ValueMember = "studentId";
                selectAStudentComboBox.DisplayMember = "studentName";
                selectAStudentComboBox.DataSource = studentNameTable;
            }

            using (sqlConn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("USE StudentTracker; SELECT * FROM course;", sqlConn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable courseTitleTable = new DataTable();
                adapter.Fill(courseTitleTable);
                selectACourseComboBox.ValueMember = "courseId";
                selectACourseComboBox.DisplayMember = "courseTitle";
                selectACourseComboBox.DataSource = courseTitleTable;
            }
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
