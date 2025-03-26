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
        


        public CourseAssessmentMark(Course course, List<int> assessmentMarks)
        {
            this.course = course;
            this.assessmentMarks = assessmentMarks;
        }

        public Course Course { get => course; set => course = value; }
        public List<int> AssessmentMarks { get => assessmentMarks; set => assessmentMarks = value; }

        public List<int> GetAllMarks()
        {
            return assessmentMarks;
        }
        
        public List<string> GetAllGrades()
        {
            List<string> grades = new List<string>();
            return grades;
        }
        
        public List<int> GetHighestMarks()
        {
            List<int> highestMarks = new List<int>();
            int maxMark = assessmentMarks.Max();
            //IEnumerable<int> maxMarkQuery = from mark in assessmentMarks
            //                                where mark == assessmentMarks.Max()
            //                                select mark;
            foreach (int mark in assessmentMarks)
            {
                if (mark == maxMark)
                {
                    highestMarks.Add(mark);
                }
            }
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
        //public string GetAverageGrade()
        //{
        //    string averageGrade;
        //    //return averageGrade;
        //}
    }
}
