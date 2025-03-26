using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Course
    {
        private Department department;
        private string code, name, description;
        private int credits;
        private double fees;

        public Department Department { get => department; set => department = value; }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Credits { get => credits; set => credits = value; }
        public double Fees { get => fees; set => fees = value; }

        public Course(Department department, string code, string name, string description, int credits)
        {
            Department = department;
            Code = code;
            Name = name;
            Description = description;
            Credits = credits;
        }
    }
}
