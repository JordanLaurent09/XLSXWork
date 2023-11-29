using System.Xml.Serialization;

namespace XMLFilesProject
{
    static class XmlMethods  // Класс с методами для сериализации/десериализации класса товаров
    {
        // Метод для сериализации списка товаров
       
        public static void SerializeGoods(List<Goods> goods)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Goods>));

            FileStream stream = new FileStream("goods.xml", FileMode.OpenOrCreate);
            serializer.Serialize(stream, goods);

            stream.Close();
        }

        // Метод для десериализации списка товаров

        public static List<Goods> DeserializeGoods()
        {
            XmlSerializer deserialize = new XmlSerializer(typeof(List<Goods>));
            List<Goods> list;
            using (FileStream deserializeStream = new FileStream("goods.xml", FileMode.Open))
            {
                list = (List<Goods>)deserialize.Deserialize(deserializeStream)!;

                
            }

            return list;
        }
    }
}
