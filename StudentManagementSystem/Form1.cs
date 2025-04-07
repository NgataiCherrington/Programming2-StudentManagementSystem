using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentManagementSystem.Lecturer;

namespace StudentManagementSystem
{
    

    public partial class Form1 : Form
    {
        List<int> highestMarks = new List<int>();
        public static List<Institution> institutions = new List<Institution>();
        public static List<Department> departments = new List<Department>();
        public static List<Course> courses = new List<Course>();

        public Form1()
        {
            InitializeComponent();
           
            institutions = Utils.SeedInstitutions();
            departments = Utils.SeedDepartments();
            courses = Utils.SeedCourses();

        }

        private void DisplayCourseDetail_btn(object sender, EventArgs e)
        {
            courses = Utils.SeedCourses();
            //make the column headings
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("idColumn", "Code");
            dataGridView1.Columns.Add("courseColumn", "Course");
            dataGridView1.Columns.Add("descriptionColumn", "Description");
            dataGridView1.Columns.Add("creditColumn", "Credits");
            dataGridView1.Columns.Add("feeColumn", "Fees");

            //make the column rows
            foreach (Course course in courses)
            {
                dataGridView1.Rows.Add(
                    course.Code,
                    course.Name,
                    course.Description,
                    course.Credits,
                    course.Fees
                    );
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
        }

        private void DisplayAllMarks_btn(object sender, EventArgs e)
        {
            List<Learner> learners = new List<Learner>();
            
            courses = Utils.SeedCourses();
            Utils.ReadFromLearnerFile("learners.txt", learners, false);

            DataTable learnerDataTable = new DataTable();
            learnerDataTable.Columns.Add("ID");
            learnerDataTable.Columns.Add("First Name");
            learnerDataTable.Columns.Add("Last Name");
            learnerDataTable.Columns.Add("Mark 1");
            learnerDataTable.Columns.Add("Mark 2");
            learnerDataTable.Columns.Add("Mark 3");
            learnerDataTable.Columns.Add("Mark 4");
            learnerDataTable.Columns.Add("Mark 5");

            foreach (var learner in learners)
            {
                if (learner.CourseAssessmentMarks == null || learner.CourseAssessmentMarks.GetAllMarks() == null)
                {
                    MessageBox.Show($"No marks found for learner {learner.FirstName} {learner.LastName}");
                    continue;
                }

                List<int> marks = new List<int>();
                var row = learnerDataTable.NewRow();
                row["ID"] = learner.Id;
                row["First Name"] = learner.FirstName;
                row["Last Name"] = learner.LastName;
                for (int i = 0; i < 5; i++)
                {
                    row[$"Mark {i + 1}"] = marks.Count > i ? marks[i] : 0;
                }
                learnerDataTable.Rows.Add(row);
            }

            dataGridView1.DataSource = learnerDataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
        }

        private void DisplayAllGrades_btn(object sender, EventArgs e)
        {

        }

        private void DisplayHighestMarks_btn(object sender, EventArgs e)
        {

        }

        private void DisplayLowestMarks_btn(object sender, EventArgs e)
        {

        }

        private void DisplayFailMarks_btn(object sender, EventArgs e)
        {

        }

        private void DisplayAvgMarks_btn(object sender, EventArgs e)
        {

        }

        private void DisplayAvgGrades_btn(object sender, EventArgs e)
        {

        }

        private void DisplayLecturerDetails_btn(object sender, EventArgs e)
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            Utils.ReadFromLecturerFile("lecturers.txt", lecturers);
            dataGridView1.DataSource = lecturers;
        }

        private void AddLearner_btn(object sender, EventArgs e)
        {
            
            
        }

        private void AddLecturer_btn(object sender, EventArgs e)
        {

        }

        private void RemoveLecturer_btn(object sender, EventArgs e)
        {

        }
        private void Exit_btn(object sender, EventArgs e)
        {

        }
    }
}
