using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace WaybillFormation
{
    public static class CSVWork
    {

        // Получение данных из csv-файла
        public static List<Product> GetFromFile()
        {       
            StreamReader reader = new StreamReader("data.csv");

            CsvConfiguration csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture);

            CsvReader csvReader = new CsvReader(reader, csvConfiguration);

            List<Product> products = csvReader.GetRecords<Product>().ToList();

            reader.Close();

            return products;
        }
    }
}
