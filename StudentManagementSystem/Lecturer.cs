using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Lecturer : Person
    {
        private EPosition position;
        private ESalary salary;
        private Course course;

        public Lecturer (int id, string firstName, string lastName, EPosition position, ESalary salary, Course course) : base (id, lastName, firstName)
        {
            this.position = position;
            this.salary = salary;
            this.course = course;
        }

        public EPosition Position { get => position; set => position = value; }
        public ESalary Salary { get => salary; set => salary = value; }
        public Course Course { get => course; set => course = value; }
    }
}
