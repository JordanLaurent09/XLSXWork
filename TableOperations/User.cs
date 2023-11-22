using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOperations
{
    internal class User
    {
        public User(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
    }
}
