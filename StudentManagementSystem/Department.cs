using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Department
    {
        private Institution institution;
        private string name;

        public Institution Institution { get => institution; set => institution = value; }
        public string Name { get => name; set => name = value; }

        public Department(Institution institution, string name)
        {
            Institution = institution;
            Name = name;
        }
    }
}
