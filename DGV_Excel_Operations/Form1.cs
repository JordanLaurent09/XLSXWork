namespace DGV_Excel_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenXLBTN_Click(object sender, EventArgs e)
        {
            UploadStudentsInfo();
        }

        private void UploadStudentsInfo()
        {
            List<Student> students = ExcelWork.GetExcelData();

            dataGridDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDGV.DataSource = students;
        }
    }
}