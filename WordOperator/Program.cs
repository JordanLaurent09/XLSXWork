using Word = Microsoft.Office.Interop.Word; // так подключить Interop

namespace WordOperator
{
    //Interop - library for Word
    // 1. requires MS Office
    // 2. добавить ссылку на проект во вкладке проекта "зависимости"
    // 3. подключить пространство имен
    // 4. создать объект приложения word
    // 5. создать в потоке документ
    // 6. добавить параграф "Paragraph"

    /*
     * интерфейсы - Word.Application, Word.Document,
     * Word.Paragraph, Word.Range, Word.WdColor
     */
    public class Program
    {
        static void Main(string[] args)
        {
            // Создание потока приложения Word
            Word.Application wordApp = new Word.Application();
            try
            {
                
                // Создание документа в потоке приложения
                Word.Document wordDoc = wordApp.Documents.Add();

                Word.Range allDoc = wordDoc.Content;
                allDoc.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;

                // Заголовок
                Word.Paragraph header = wordDoc.Paragraphs.Add();

                // Обращаемся к диапазону КОНКРЕТНОГО ПАРАГРАФА
                header.Range.Font.Name = "Arial";
                header.Range.Font.Size = 20;
                header.Range.Font.Bold = 1;
                header.Range.Font.Color = Word.WdColor.wdColorOrange;


                header.Range.Text = "Первый заголовок\n";

                // Параграф
                Word.Paragraph headerSecondary = wordDoc.Paragraphs.Add();

                // Обращаемся к диапазону КОНКРЕТНОГО ПАРАГРАФА
                headerSecondary.Range.Font.Name = "Arial";
                headerSecondary.Range.Font.Size = 14;
                headerSecondary.Range.Font.Bold = 0;
                headerSecondary.Range.Font.Color = Word.WdColor.wdColorOliveGreen;


                headerSecondary.Range.Text = "Товарищи! постоянный количественный рост и сфера нашей активности способствует подготовки и реализации форм развития. Повседневная практика показывает, что новая модель организационной деятельности требуют определения и уточнения существенных финансовых и административных условий. Равным образом начало повседневной работы по формированию позиции обеспечивает широкому кругу (специалистов) участие в формировании позиций, занимаемых участниками в отношении поставленных задач. Не следует, однако забывать, что постоянное информационно-пропагандистское обеспечение нашей деятельности в значительной степени обуславливает создание соответствующий условий активизации. Товарищи! реализация намеченных плановых заданий в значительной степени обуславливает создание соответствующий условий активизации. С другой стороны рамки и место обучения кадров позволяет оценить значение существенных финансовых и административных условий.";


                wordDoc.SaveAs($"{Directory.GetCurrentDirectory()}\\myColoredDoc.docx");

                // Открытие существующего документа в потоке приложения
                //Word.Document existingWordDocument = wordApp.Documents.Open("C:\\Users\\C4PC10\\Documents\\Попытка1.docx");

                // Настройки для ВСЕГО текста
                //Word.Range mainRange = existingWordDocument.Content;

                //mainRange.Font.Name = "Arial";
                //mainRange.Font.Size = 14;
                //mainRange.Font.Bold = 1;
                //mainRange.Font.Color = Word.WdColor.wdColorOliveGreen;

                

                // Обращаемся к диапазону существующего документа
                //Word.Range range = existingWordDocument.Content;

                //range.Find.Execute("Привет, дружище, ты еще не знаешь, что тебе предстоит испытать", ReplaceWith: "" +
                //    "Доброе утро, ну тебя даже вчерашний шторм не разбудил");


                //existingWordDocument.Save();
                // Добавляем новый параграф в документ
                //Word.Paragraph firstPar = wordDoc.Paragraphs.Add();

                //firstPar.Range.Text = "Привет, дружище, ты еще не знаешь, что тебе предстоит испытать\n";

                //Word.Paragraph secondPar = wordDoc.Paragraphs.Add();

                //secondPar.Range.Text = "Второй параграф";

                //wordDoc.SaveAs("Попытка1.docx");                
            }
            catch(Exception e)
            {
                Console.WriteLine("Возникла ошибка: " + e.Message);
            }
            finally
            {
                wordApp.Quit();
            }
        }
    }
}