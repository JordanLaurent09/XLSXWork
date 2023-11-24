using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
namespace CSV_WinForms
{
    public partial class Form1 : Form
    {
        private static string _path = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();
            // ShowCsvFilesCB.Items.Add
        }

        // Добавление в комбобокс всех файлов с  необходимым расширением
        private void AddFilesNameBTN_Click(object sender, EventArgs e)
        {
            AddFiles();
        }

        // Выбор необходимого имени файла и его размещение в текстбоксе

        private void ShowCsvFilesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileNameTB.Text = ShowCsvFilesCB.SelectedItem.ToString();
        }

        private void AddFiles()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(_path);
            FileInfo[] files = dirInfo.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Name.EndsWith(".csv"))
                {
                    ShowCsvFilesCB.Items.Add(files[i].Name);
                }
            }
        }

        private void OpenFileBTN_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(FileNameTB.Text);

            CsvConfiguration csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = "," // Определяет символ разделителя данных
            };

            CsvReader csvReader = new CsvReader(reader, csvConfiguration);

            List<string> strange = csvReader.GetRecords<string>().ToList();

            DataGridDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridDGV.DataSource = strange;
        }
    }
}