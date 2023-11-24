using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
namespace CSV_Operator
{
    // library CSVhelper
    /// <summary>
    /// Запись объектов в CSV-файл - используется объект класса StreamWriter
    /// Чтение объектов из CSV-файла - испольуется объект класса StreamReader
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Чтение из файла
            //StreamReader reader = new StreamReader("example.csv");

            //CsvConfiguration csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
            //{
            //    Delimiter = "," // Определяет символ разделителя данных
            //};

            //CsvReader csvReader = new CsvReader(reader, csvConfiguration);

            //List<Person> people = csvReader.GetRecords<Person>().ToList();

            //reader.Close();

            //foreach(Person person in people)
            //{
            //    Console.WriteLine($"Имя - {person.Name}, возраст - {person.Age}");
            //}

            // Запись в файл
            //StreamWriter writer = new StreamWriter("example.csv");

            //CsvWriter csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));

            //List<Person> people = new List<Person>()
            //{
            //    new Person(){Name = "Albert", Age = 24},
            //    new Person(){Name = "Dmitry", Age = 36},
            //    new Person(){Name = "Aleksey", Age = 18}
            //};

            //csvWriter.WriteRecords(people);
            //writer.Close();


            StreamReader reader = new StreamReader("inventoryControl.csv");

            CsvReader csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));

            List<Goods> goods = csvReader.GetRecords<Goods>().ToList();

            //foreach(Goods good in goods)
            //{
            //    Console.WriteLine($"{good.Name} {good.Quantity} {good.Price} {good.Description}");
            //}

            string? option = Console.ReadLine();

            switch (option)
            {
                case ("show"):
                    foreach (Goods good in goods)
                    {
                        Console.WriteLine($"{good.Name} {good.Quantity} {good.Price} {good.Description}");
                    }
                    break;
                case ("maxPrice"):
                    Console.WriteLine(goods.Max(p => p.Price));
                    break;
                case ("minPrice"):
                    Console.WriteLine(goods.Min(p => p.Price));
                    break;
                case ("averagePrice"):
                    Console.WriteLine(goods.Average(p => p.Price));
                    break;
                case ("TotalItemsAmount"):
                    Console.WriteLine(goods.Count);
                    break;
            }
                     
            //Console.WriteLine(goods.Max(p=>p.Name));
            //Console.WriteLine(goods.Average(p=>p.Price));

            //Array.Sort(goods.ToArray());
            
        }
    }
}