
using System.ComponentModel;

namespace DGV_DataSource
{
    public class Person
    {
        [DisplayName("Имя пользователя")]
        public string Name { get; set; }

        [DisplayName("Возраст пользователя")]
        public int Age { get; set; }

        [DisplayName("Рост пользователя")]
        public double Height { get; set; }

        [DisplayName("Вес пользователя")]
        public double Weight { get; set; }

        public Person(string name, int age, double height, double weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }
    }
}
