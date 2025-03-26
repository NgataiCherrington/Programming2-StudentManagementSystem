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
            institutions.Add();
            institutions.Add();
            institutions.Add();
        }

        public static List<Department> SeedDepartments()
        {
            departments.Add();
            departments.Add();
            departments.Add();
        }

        public static List<Course> SeedCourses()
        {
           courses.Add();
           courses.Add();
           courses.Add();
        }
    }
}
