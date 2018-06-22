using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fabFiveProject
{
    public partial class addNewStudent : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["fabFiveProject.Properties.Settings.StudentTrackerConnectionString"].ConnectionString;
        SqlConnection sqlConn;

        public addNewStudent()
        {
            InitializeComponent();
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            using (sqlConn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("USE StudentTracker; INSERT INTO student (studentName) VALUES (@newName);", sqlConn))
            {
                sqlConn.Open();
                comd.Parameters.AddWithValue("@newName", newStudentTextBox.Text);
                comd.ExecuteScalar();
                var result = MessageBox.Show("Student added!");
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }

        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
