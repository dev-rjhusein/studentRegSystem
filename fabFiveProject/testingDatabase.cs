using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fabFiveProject
{
    public partial class testingDatabase : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["fabFiveProject.Properties.Settings.StudentTrackerConnectionString"].ConnectionString;
        BindingSource studentBindingSource = new BindingSource();
        BindingSource courseBindingSource = new BindingSource();
        BindingSource completeBindingSource = new BindingSource();
        BindingSource semesterBindingSource = new BindingSource();
        SqlDataAdapter adapter;

        public testingDatabase()
        {
            InitializeComponent();
        }
        
        private void resetButton_Click(object sender, EventArgs e)
        {
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand("USE MASTER " +
    "If DB_ID('StudentTracker') IS NOT NULL DROP DATABASE StudentTracker;" +
    "       CREATE DATABASE StudentTracker;" +
    "       USE StudentTracker;" +
    "       CREATE TABLE student" +
    "           (studentId INT NOT NULL IDENTITY," +
    "           studentName NVARCHAR(100) NOT NULL," +
    "           CONSTRAINT pk_student PRIMARY KEY(studentId));" +

    "       CREATE TABLE course" +
    "           (courseId INT NOT NULL IDENTITY," +
    "           courseTitle NVARCHAR(100) NOT NULL," +
    "           CONSTRAINT pk_course PRIMARY KEY(courseId));" +

    "       CREATE TABLE student_courses_complete" +
    "           (courseId INT NOT NULL," +
    "           studentId INT NOT NULL," +
    "           CONSTRAINT fk_course_comp FOREIGN KEY(courseId) REFERENCES course(courseId)," +
    "           CONSTRAINT fk_student_comp FOREIGN KEY(studentId) REFERENCES student(studentId));" +

    "       CREATE TABLE semesters_offered" +
    "           (courseId INT NOT NULL," +
    "           semester NVARCHAR(20) NOT NULL," +
    "           CONSTRAINT fk_course_sem FOREIGN KEY(courseId) REFERENCES course(courseId));" +

            "INSERT INTO student(studentName) VALUES('Rami Husein');" +
            "INSERT INTO student(studentName) VALUES('Rhonda Malcolm');" +
            "INSERT INTO student(studentName) VALUES('Shaun Hembree');" +
            "INSERT INTO student(studentName) VALUES('Jose Felix');" +
            "INSERT INTO student(studentName) VALUES('Charles Roseboro');" +

            "INSERT INTO course(courseTitle) VALUES('CISS 243');" +
            "INSERT INTO course(courseTitle) VALUES('PHIL 324');" +
            "INSERT INTO course(courseTitle) VALUES('PHIL 101');" +
            "INSERT INTO course(courseTitle) VALUES('ENGL 101');" +
            "INSERT INTO course(courseTitle) VALUES('ARTS 375');" +
            "INSERT INTO course(courseTitle) VALUES('PHIL 203');" +


            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(1, 1);" +
            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(1, 3);" +
            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(1, 5);" +

            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(2, 1);" +
            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(2, 2);" +
            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(2, 6);" +

            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(3, 2);" +
            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(3, 4);" +
            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(3, 6);" +

            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(4, 3);" +
            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(4, 2);" +
            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(4, 1);" +

            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(5, 5);" +
            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(5, 4);" +
            "INSERT INTO student_courses_complete(studentId, courseId) VALUES(5, 3);" +



            "INSERT INTO semesters_offered(courseId, semester) VALUES(1, 'Fall');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(1, 'Spring');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(2, 'Spring');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(2, 'Summer');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(3, 'Fall');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(3, 'Spring');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(3, 'Summer');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(4, 'Fall');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(4, 'Summer');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(5, 'Fall');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(5, 'Spring');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(5, 'Summer');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(6, 'Summer');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(6, 'Fall');" +
            "INSERT INTO semesters_offered(courseId, semester) VALUES(6, 'Spring');", conn))
                {
                    conn.Open();
                    comd.ExecuteScalar();
                    Close();
                }
            }
        }

        private void testingDatabase_Load(object sender, EventArgs e)
        {
            /* DISPLAY ALL INFO IN STUDENT TABLE */
            studentData.DataSource = studentBindingSource;
            adapter = new SqlDataAdapter("USE StudentTracker; SELECT * FROM student;", connectionString);
            SqlCommandBuilder comdBuilder = new SqlCommandBuilder(adapter);
            DataTable studentDT = new DataTable();
            adapter.Fill(studentDT);
            studentBindingSource.DataSource = studentDT;

            /*DISPLAY ALL INFO IN COURSE TABLE*/
            courseData.DataSource = courseBindingSource;
            adapter = new SqlDataAdapter("USE StudentTracker; SELECT * FROM course;", connectionString);
            comdBuilder = new SqlCommandBuilder(adapter);
            DataTable courseDT = new DataTable();
            adapter.Fill(courseDT);
            courseBindingSource.DataSource = courseDT;

            /*DISPLAY ALL INFO IN STUDENT_COURSES_COMPLETE TABLE*/
            completeData.DataSource = completeBindingSource;
            adapter = new SqlDataAdapter("USE StudentTracker; SELECT * FROM student_courses_complete;", connectionString);
            comdBuilder = new SqlCommandBuilder(adapter);
            DataTable completeDT = new DataTable();
            adapter.Fill(completeDT);
            completeBindingSource.DataSource = completeDT;

            /*DISPLAY ALL INFO IN SEMSTERS_OFFERED TABLE */
            semesterData.DataSource = semesterBindingSource;
            adapter = new SqlDataAdapter("USE StudentTracker; SELECT * FROM semesters_offered;", connectionString);
            comdBuilder = new SqlCommandBuilder(adapter);
            DataTable semesterDT = new DataTable();
            adapter.Fill(semesterDT);
            semesterBindingSource.DataSource = semesterDT;

        }
    }
}
