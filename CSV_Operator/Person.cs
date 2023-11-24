using CsvHelper.Configuration.Attributes;
namespace CSV_Operator
{
    public class Person
    {
        [Name("Name")] // если хотим назвать шапку по-своему
        public string Name { get; set; }

        [Name("Age")]
        public int Age { get; set; }


    }
}
