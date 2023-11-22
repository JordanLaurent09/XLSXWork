using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGW_Practice_1
{
     class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

        public string Faculty { get; set; }

        public Student(string name, string surname, int age, string faculty)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Faculty = faculty;
        }
    }
}
