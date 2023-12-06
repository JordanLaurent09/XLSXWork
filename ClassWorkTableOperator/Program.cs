using Word = Microsoft.Office.Interop.Word;
namespace ClassWorkTableOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Word.Application wordApp = new Word.Application();


            try
            {
                CreateAndUpdateWF("fileOne");
                CreateAndUpdateWF("fileTwo");
                CreateAndUpdateWF("fileThree");
            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message);
            }
            finally 
            {
                wordApp.Quit();
            }

            void CreateAndUpdateWF(string fileName)
            {
                
                Word.Document wordDoc = wordApp.Documents.Add();

                Word.Range range = wordDoc.Content;

                Word.Table newTable = wordDoc.Tables.Add(range, NumRows: 3, NumColumns: 3);

                for(int row = 1; row <= 3; row++)
                {
                    for(int column = 1; column <= 3; column++)
                    {
                        newTable.Cell(row, column).Range.Text = random.Next(-10, 10).ToString();
                    }
                }

                wordDoc.SaveAs2($"{Directory.GetCurrentDirectory()}\\{fileName}.docx");

                wordDoc.Close();
            }

        }
    }
}