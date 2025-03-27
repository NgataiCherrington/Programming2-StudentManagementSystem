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
        List<int> highestMarks = new List<int>();
        public Form1()
        {
            InitializeComponent();  
            
            CourseAssessmentMark ngatai = new CourseAssessmentMark(null, new List<int> { 10, 49, 50, 75, 100, 100 });
            MessageBox.Show(string.Join(",", ngatai.GetHighestMarks()));

            CourseAssessmentMark aPlus = new CourseAssessmentMark(null, new List<int> { 88 });
            MessageBox.Show(string.Join(",", aPlus.GradeCalculator()));

            CourseAssessmentMark lowMarkErrorHandle = new CourseAssessmentMark(null, new List<int> { 67, 95, 52 });
            MessageBox.Show(string.Join(",", lowMarkErrorHandle.GetLowestMarks()));

            CourseAssessmentMark getFailMarkErrorHandle = new CourseAssessmentMark(null, new List<int> { 87, 68, 23 });
            MessageBox.Show(string.Join(",", getFailMarkErrorHandle.GetFailMarks()));

            CourseAssessmentMark averageMarkErrorHandle = new CourseAssessmentMark(null, new List<int> { 97, 64, 13, 54, 44, 76 });
            MessageBox.Show(string.Join(",", averageMarkErrorHandle.GetAverageMarks()));

            CourseAssessmentMark averageGradeErrorHandle = new CourseAssessmentMark(null, new List<int> { 97, 64, 13, 54, 44, 76 });
            MessageBox.Show(string.Join(",", averageGradeErrorHandle.GetAverageGrade()));


        }
    }
}
