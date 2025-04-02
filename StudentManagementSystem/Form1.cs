using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public enum Eposition
        {
            LECTURER = 0,
            SENIOR_LECTURER = 1,
            PRINCIPAL_LECTURER = 2,
            ASSOCIATE_PROFESSOR = 3,
            PROFESSOR = 4
        }

        public enum Esalary
        {
            LECTURER_SALARY = 85000,
            SENIOR_LECTURER_SALARY = 100000,
            PRINCIPAL_LECTURER_SALARY = 115000,
            ASSOCIATE_PROFESSOR_SALARY = 130000,
            PROFESSOR_SALARY = 145000
        }

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

            //CourseAssessmentMark ngatai = new CourseAssessmentMark(null, new List<int> { 10, 49, 50, 75, 100, 100 });
            //MessageBox.Show(string.Join(",", ngatai.GetHighestMarks()));

            //CourseAssessmentMark aPlus = new CourseAssessmentMark(null, new List<int> { 63 });
            //MessageBox.Show(string.Join(",", aPlus.GetAllGrades()));

            //CourseAssessmentMark lowMarkErrorHandle = new CourseAssessmentMark(null, new List<int> { 67, 95, 52 });
            //MessageBox.Show(string.Join(",", lowMarkErrorHandle.GetLowestMarks()));

            //CourseAssessmentMark getFailMarkErrorHandle = new CourseAssessmentMark(null, new List<int> { 87, 68, 23 });
            //MessageBox.Show(string.Join(",", getFailMarkErrorHandle.GetFailMarks()));

            //CourseAssessmentMark averageMarkErrorHandle = new CourseAssessmentMark(null, new List<int> { 97, 64, 13, 54, 44, 76 });
            //MessageBox.Show(string.Join(",", averageMarkErrorHandle.GetAverageMarks()));

            //CourseAssessmentMark averageGradeErrorHandle = new CourseAssessmentMark(null, new List<int> { 97, 64, 13, 54, 44, 76 });
            //MessageBox.Show(string.Join(",", averageGradeErrorHandle.GetAverageGrade()));

            //Institution institution1 = institutions[0];
            //Institution institution2 = institutions[1]; 
            //Department department1 = departments[0]; 
            //Department department2 = departments[1];
            Course course1 = courses[0];
            Course course2 = courses[1];
            //MessageBox.Show(institution1.DisplayInfo().ToString());
            //MessageBox.Show(institution2.DisplayInfo().ToString());
            //MessageBox.Show(department1.DisplayInfo().ToString()); 
            //MessageBox.Show(department2.DisplayInfo().ToString());
            MessageBox.Show(course1.DisplayInfo().ToString());
            MessageBox.Show(course2.DisplayInfo().ToString());




        }
    }
}
