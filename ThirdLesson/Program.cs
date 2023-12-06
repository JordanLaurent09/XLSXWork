using Word = Microsoft.Office.Interop.Word;
namespace ThirdLesson
{
    // Продолжение работы с Word
    // WordTable - интерфейс для создания таблиц в Word
    // Индексация в таблицах начинается с 1
    // wordDoc.Tables - коллекция, что означает - она ИТЕРИРУЕМАЯ, значит wordDoc.Tables[1] можно написать
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // для чтения из ворд-файла
            Word.Application wordApp = new Word.Application();
            Word.Document wodDoc = wordApp.Documents.Open(Directory.GetCurrentDirectory() + "\\tableDoc.docx");

            try
            {
                Word.Table table = wodDoc.Tables[1];

                foreach(Word.Row row in table.Rows)
                {
                    foreach(Word.Cell cell in row.Cells)
                    {
                        cell.Range.Text = $"Знач: {random.Next(-10, 10)}";
                    }
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                wodDoc.Save();
                wordApp.Quit();
            }












            // Для записи в ворд-файл
            //Word.Application wordApp = new Word.Application();
            //Word.Document wodDoc = wordApp.Documents.Open(Directory.GetCurrentDirectory() + "\\tableDoc.docx");

            //try
            //{
            //    AddNewTable(3, 4, "Вторая таблица");
            //    AddNewTable(6, 2, "Третья таблица");
            //}
            //catch(Exception e)
            //{

            //}
            //finally
            //{
            //    wodDoc.Save();
            //    wordApp.Quit();
            //}


            //Word.Range range = wodDoc.Content;

            //Word.Table wordFirstTable = wodDoc.Tables.Add(range, NumRows: 3, NumColumns: 4); // Так в Ворде таблица создается

            //wordFirstTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
            //wordFirstTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;

            //wordFirstTable.Borders.OutsideColor = Word.WdColor.wdColorBlack;

            //wordFirstTable.Borders.InsideColor = Word.WdColor.wdColorBlack;

            //wordFirstTable.Cell(1, 1).Range.Text = "Я ячейка А1";
            //wordFirstTable.Cell(2, 2).Range.Text = "Я ячейка B2";

            //wodDoc.SaveAs(Directory.GetCurrentDirectory() + "\\tableDoc.docx");

            //wodDoc.Close();

            //wordApp.Quit();

            //void AddNewTable(int rows, int columns, string tableName)
            //{
            //    Word.Paragraph paragraph = wodDoc.Paragraphs.Add();
            //    paragraph.Range.Text = $"\n{tableName}\n";

            //    Word.Table newTable = wodDoc.Tables.Add(paragraph.Range, NumRows: rows, NumColumns: columns);

            //    // Настройка новой таблицы
            //    newTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            //    newTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            //    newTable.Borders.OutsideColor = Word.WdColor.wdColorLightGreen;
            //    newTable.Borders.InsideColor = Word.WdColor.wdColorLightGreen;

            //    for(int i = 1; i <= rows; i++)
            //    {
            //        for(int j = 1; j <= columns; j++)
            //        {
            //            newTable.Cell(i, j).Range.Text = $"Яч: {i}:{j}";
            //        }
            //    }
            //}
        }




    }
}