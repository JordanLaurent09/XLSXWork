using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word = Microsoft.Office.Interop.Word;
namespace WFWordOperations
{
    public partial class Form1 : Form
    {
        private static Word.Application wordApp;
        private static Word.Document doc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filePathTB.Text = "C:\\Users\\C4PC10\\source\\repos\\XLSXWork\\WFWordOperations\\bin\\Debug\\net6.0-windows\\SisterSister.docx";
            wordApp = new Word.Application();

            doc = wordApp.Documents.Open(filePathTB.Text);


        }

        private void addParagraphBTN_Click(object sender, EventArgs e)
        {
            Word.Paragraph paragraph = doc.Paragraphs.Add();

            paragraph.Range.Font.Name = fontStyleCMB.Text;
            paragraph.Range.Font.Size = float.Parse(textSizeTB.Text);
            paragraph.Range.Font.Bold = 0;
            paragraph.Range.Font.Color = fontColorCMB.SelectedItem switch
            {
                "Оранжевый" => Word.WdColor.wdColorOrange,
                "Черный" => Word.WdColor.wdColorBlack
            };

            paragraph.Range.Text = paragraphTB.Text + '\n';

            doc.SaveAs("SisterSister.docx");
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            doc.Close();
            wordApp.Quit();
        }
    }
}