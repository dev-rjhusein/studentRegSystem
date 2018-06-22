using System;
using System.Windows.Forms;

namespace fabFiveProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click_1(object sender, EventArgs e)
        {
            addNewStudent addForm = new addNewStudent();
            addForm.ShowDialog();
        }

        private void addCourseButton_Click_1(object sender, EventArgs e)
        {
            addNewCourse addCourse = new addNewCourse();
            addCourse.ShowDialog();
        }

        private void enrollStudentCourseButton_Click_1(object sender, EventArgs e)
        {
            enrollStudentInCourse enrollStudent = new enrollStudentInCourse();
            enrollStudent.ShowDialog();
        }

        private void courseListButton_Click_1(object sender, EventArgs e)
        {
            showStudentsInCourse studentInCourse = new showStudentsInCourse();
            studentInCourse.ShowDialog();
        }

        private void studentScheduleButton_Click_1(object sender, EventArgs e)
        {
            showStudentCourseSchedule studentsCourses = new showStudentCourseSchedule();
            studentsCourses.ShowDialog();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void testButton_Click_1(object sender, EventArgs e)
        {
            testingDatabase testingTesting = new testingDatabase();
            testingTesting.ShowDialog();
        }
    }
}
