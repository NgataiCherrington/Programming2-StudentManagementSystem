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
        public static List<Learner> learners = new List<Learner>();

        public Form1()
        {
            InitializeComponent();
           
            institutions = Utils.SeedInstitutions();
            departments = Utils.SeedDepartments();
            courses = Utils.SeedCourses();
            Utils.ReadFromLearnerFile("learners.txt", learners, false);
        }

        private void DisplayCourseDetail_btn(object sender, EventArgs e)
        {
            courses = Utils.SeedCourses();
            //make the column headings
            DataTable courseDataTable = new DataTable();
            courseDataTable.Columns.Clear();
            courseDataTable.Columns.Add("Course");
            courseDataTable.Columns.Add("Description");
            courseDataTable.Columns.Add("Credits");
            courseDataTable.Columns.Add("Fees");


            //make the column rows
            foreach (Course course in courses)
            {
                var row = courseDataTable.NewRow();
                row["Course"] = course.DisplayCodeName();
                row["Description"] = course.Description;
                row["Credits"] = course.Credits;
                row["Fees"] = course.Fees;

                courseDataTable.Rows.Add(row);
            }

            dataGridView1.DataSource = courseDataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
        }

        private void DisplayAllMarks_btn(object sender, EventArgs e)
        {
 

           

            DataTable learnerDataTable = new DataTable();
            learnerDataTable.Clear();
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
            MessageBox.Show(string.Join(", ", learner.CourseAssessmentMarks.AssessmentMarks));
                List<int> marks = new List<int>(learner.CourseAssessmentMarks.GetAllMarks());
                List<int> assessmentMarks = new List<int>();

                var row = learnerDataTable.NewRow();
                row["ID"] = learner.Id;
                row["First Name"] = learner.FirstName;
                row["Last Name"] = learner.LastName;
                for (int i = 0; i < 5; i++)
                {
                    row[$"Mark {i + 1}"] = assessmentMarks.Count > i ? assessmentMarks[i] : 0;
                }
                learnerDataTable.Rows.Add(row);
            }

            dataGridView1.DataSource = learnerDataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
        }

        private void DisplayAllGrades_btn(object sender, EventArgs e)
        {
            List<Learner> learners = new List<Learner>();
            Utils.ReadFromLearnerFile("learners.txt", learners, false);

            DataTable gradeDataTable = new DataTable();
            gradeDataTable.Clear();
            gradeDataTable.Columns.Add("Id");
            gradeDataTable.Columns.Add("First Name");
            gradeDataTable.Columns.Add("Last Name");
            gradeDataTable.Columns.Add("Code");
            gradeDataTable.Columns.Add("Grade 1");
            gradeDataTable.Columns.Add("Grade 2");
            gradeDataTable.Columns.Add("Grade 3");
            gradeDataTable.Columns.Add("Grade 4");
            gradeDataTable.Columns.Add("Grade 5");




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
