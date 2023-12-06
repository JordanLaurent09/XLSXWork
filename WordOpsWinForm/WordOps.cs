using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace WordOpsWinForm
{
    static class WordOps
    {
        public static Word.Application CreateWordApplicaton()
        {
            return new Word.Application();
        }

        public static Word.Document CreateWordDocument(Word.Application app)
        {
            return app.Documents.Add();
        }

        public static void CreateRandomWordTable(Word.Application app, Word.Document doc, int first, int second, int rows, int columns, string docName)
        {
            Random random = new Random();
            Word.Range range = doc.Content;

            Word.Table newTable = doc.Tables.Add(range, NumRows:rows, NumColumns: columns);

            for(int row = 1; row <= rows; row++)
            {
                for(int column = 1; column<=columns; column++)
                {
                    newTable.Cell(row, column).Range.Text = random.Next(first, second).ToString();
                }
            }
            doc.SaveAs2($"{Directory.GetCurrentDirectory()}\\{docName}.docx");
            doc.Close();
            app.Quit();
        }
    }
}
