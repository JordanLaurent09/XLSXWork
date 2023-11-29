using System.Xml.Serialization; // классы для работы с xml с целью сериализации/десериализации
namespace XMLFilesProject
{
    class Program
    {
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

            XmlSerializer deserialize = new XmlSerializer(typeof(List<Person>));
            List<Person> list;
            using (FileStream deserializeStream = new FileStream("persons.xml", FileMode.Open))
            {
                list = (List<Person>)deserialize.Deserialize(deserializeStream)!;

                foreach(var person in list)
                {
                    Console.WriteLine($"{person.Name} {person.Age}");
                }
            }
        }
    }
}