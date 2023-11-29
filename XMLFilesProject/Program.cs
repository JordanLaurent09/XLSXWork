using System.Xml.Serialization; // классы для работы с xml с целью сериализации/десериализации
namespace XMLFilesProject
{
    class Program
    {
        private static List<Goods>? _listOfGoods = new List<Goods>();
        static void Main(string[] args)
        {
            //List<Person> people = new List<Person>() {
            //new Person() { Name = "Валерий", Age = 56 },
            //new Person() { Name = "Николай", Age = 22 },
            //new Person() { Name = "Владислав", Age = 16 }
            //};

            //XmlSerializer serializer = new XmlSerializer(typeof (List<Person>));

            //FileStream stream = new FileStream("persons.xml", FileMode.Create);
            //serializer.Serialize(stream, people);

            //stream.Close();

            //XmlSerializer deserialize = new XmlSerializer(typeof(List<Person>));
            //List<Person> list;
            //using (FileStream deserializeStream = new FileStream("persons.xml", FileMode.Open))
            //{
            //    list = (List<Person>)deserialize.Deserialize(deserializeStream)!;

            //    foreach(var person in list)
            //    {
            //        Console.WriteLine($"{person.Name} {person.Age}");
            //    }
            //}

            List<Goods> goods = new List<Goods>()
            {
                new Goods(){ Title = "Блинчики", Description = "Очень вкусные блинчики с сыром и ветчиной", Price = 23.22},
                new Goods(){ Title = "Пончики", Description = "Очень вкусные пончики в пудре", Price = 77.13},
                new Goods(){ Title = "Кофе", Description = "Очень вкусное кофе", Price = 50.27}
            };

            //XmlMethods.SerializeGoods(goods);
            //List<Goods> newGoods = XmlMethods.DeserializeGoods();
            
            
            //foreach(var good in newGoods)
            //{
            //    Console.WriteLine($"{good.Title} {good.Description} {good.Price}");
            //}

            bool isExit = false;

            while(true)
            {
                Console.WriteLine("Что хотите сделать?\nПРОСМОТР - Просмотреть список товаров\nДОБАВИТЬ - добавить товар в список");
                string? option = Console.ReadLine();
                switch (option)
                {
                    case "ПРОСМОТР":
                        _listOfGoods = XmlMethods.DeserializeGoods();


                        foreach (var good in _listOfGoods)
                        {
                            Console.WriteLine($"{good.Title} {good.Description} {good.Price}");
                        }
                        break;

                    case "ДОБАВИТЬ":
                        Console.WriteLine("Введите название товара");
                        string? title = Console.ReadLine();
                        Console.WriteLine("Введите описание товара");
                        string? description = Console.ReadLine();
                        Console.WriteLine("Введите цену товара");
                        double price = double.Parse(Console.ReadLine()!);
                        Goods newGood = new Goods() { Title = title!, Description = description!, Price = price!};
                        _listOfGoods.Add(newGood);
                        XmlMethods.SerializeGoods(_listOfGoods);
                        break;
                }
            }
        }
    }
}