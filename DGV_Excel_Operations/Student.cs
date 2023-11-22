using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGV_Excel_Operations
{
    internal class Student
    {
     
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Faculty { get; set; }

        public string Course { get; set; }

        public string Group { get; set; }

        public string StudentCode { get; set; }

        public Student(string name, string surname, string age, string faculty, string course, string group, string studentCode)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Faculty = faculty;
            Course = course;
            Group = group;
            StudentCode = studentCode;
        }
    }
}
