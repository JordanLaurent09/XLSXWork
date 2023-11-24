using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
namespace CSV_Operator
{
    // library CSVhelper
    /// <summary>
    /// Запись объектов в CSV-файл - используется объект класса StreamWriter
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("example.csv");

            CsvWriter csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));

            List<Person> people = new List<Person>()
            {
                new Person(){Name = "Albert", Age = 24},
                new Person(){Name = "Dmitry", Age = 36},
                new Person(){Name = "Aleksey", Age = 18}
            };
        }
    }
}