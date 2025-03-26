using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Utils
    {
        public static List<Institution> institutions = new List<Institution>();
        public static List<Department> departments = new List<Department>();
        public static List<Course> courses = new List<Course>();

        public static List<Institution> SeedInstitutions()
        {
            institutions.Add(new Institution("Otago Polytechnic", "Otago", "New Zealand"));
            institutions.Add(new Institution("University of Auckland", "Auckland", "New Zealand"));
            institutions.Add(new Institution("Auckland University of Technology", "Auckland", "New Zealand"));

            return institutions;
        }

        public static List<Department> SeedDepartments()
        {
            departments.Add(new Department(institutions[0], "Psychology"));
            departments.Add(new Department(institutions[1], "Information Technology"));
            departments.Add(new Department(institutions[2], "History"));

            return departments;
        }

        public static List<Course> SeedCourses()
        {
           courses.Add(new Course(departments[0], "PSY 101", "Intro to Psychology", "Basic psychological principles", 3));
           courses.Add(new Course(departments[1], "IT 202", "Data Structures", "Organizing data efficiently", 4));
           courses.Add(new Course(departments[2], "HIS 305", "Ancient Civilizations", "Early human societies", 3));

            return courses;
        }
    }
}
