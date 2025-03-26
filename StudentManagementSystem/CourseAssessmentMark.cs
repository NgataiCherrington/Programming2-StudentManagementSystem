using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class CourseAssessmentMark
    {
        private Course course;
        private List<int> assessmentMarks = new List<int>();
   
        public static void CourseAssessmentMarks(Course course, List<int> assessmentMarks)
        {

        }
        
        public List<int> GetAllMarks()
        {
            List<int> marks = new List<int>();
            return marks;
        }
        
        public List<string> GetAllGrades()
        {
            List<string> grades = new List<string>();
            return grades;
        }
        
        public List<int> GetHighestMarks()
        {
            List<int> highestMarks = new List<int>();
            return highestMarks;
        }
        
        public List<int> GetLowestMarks()
        {
            List<int> lowestMarks = new List<int>();
            return lowestMarks;
        }
        public List<int> GetFailMarks()
        {
            List<int> failMarks = new List<int>(); 
            return failMarks;
        }
        public double GetAverageMarks()
        {
            double averageMarks = 0;
            return averageMarks;
        }
        public string GetAverageGrade()
        {
            string averageGrade;
            return averageGrade;
        }
    }
}
