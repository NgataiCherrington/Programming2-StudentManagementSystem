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

        public List<string> GradeCalculator()
        {
            List<string> gradedMarks = new List<string>();

            foreach (var score in assessmentMarks)
            {
                if (score > 89)
                {
                    gradedMarks.Add("A+");
                }
                else if (score >= 89)
                {
                    gradedMarks.Add("A");
                }
                else if (score >= 84)
                {
                    gradedMarks.Add("A-");
                }
                else if (score >= 79)
                {
                    gradedMarks.Add("B+");
                }
                else if (score >= 74)
                {
                    gradedMarks.Add("B");
                }
                else if (score >= 69)
                {
                    gradedMarks.Add("B-");
                }
                else if(score >= 64)
                {
                    gradedMarks.Add("C+");
                }
                else if (score >= 59)
                {
                    gradedMarks.Add("C");
                }
                else if (score >= 54)
                {
                    gradedMarks.Add("C-");
                }
                else if (score >= 49)
                {
                    gradedMarks.Add("D");
                }
                else if (score >= 39)
                {
                    gradedMarks.Add("E");
                }
            }    
            return gradedMarks;
        }

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
            
            foreach (var mark in assessmentMarks)
            {
                if (mark >= 50 && mark <= 54)
                {
                    lowestMarks.Add(mark);
                }
            }

            return lowestMarks;
        }
        public List<int> GetFailMarks()
        {
            List<string> gradedMarks = new List<string>();
            List<int> failMarks = new List<int>(); 

            foreach (var mark in assessmentMarks)
            {
                if (mark <= 49)
                {
                    failMarks.Add(mark);
                }
            }
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
