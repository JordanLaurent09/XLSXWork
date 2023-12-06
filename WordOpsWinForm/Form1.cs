using System.DirectoryServices.ActiveDirectory;
using Word = Microsoft.Office.Interop.Word;
namespace WordOpsWinForm
{
    public partial class Form1 : Form
    {
        public static Word.Application wordApp = WordOps.CreateWordApplicaton();
        public Word.Document wordDOc = WordOps.CreateWordDocument(wordApp);
        public Form1()
        {
            InitializeComponent();
           
        }

        private void createDocBTN_Click(object sender, EventArgs e)
        {
            CreateDoc();
            
        }

        private void CreateDoc()
        {
            WordOps.CreateRandomWordTable(wordApp, wordDOc, int.Parse(lowerNumberTB.Text), int.Parse(upperNumberTB.Text), int.Parse(rowsTB.Text), int.Parse(columnsTB.Text), docNameTB.Text);
        }
    }
}