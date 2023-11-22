namespace DGW_Practice_1
{

    public partial class Form1 : Form
    {
        private List<Student> _students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }



        private void AddStudentBTN_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void showStudentsBTN_Click(object sender, EventArgs e)
        {
            UploadStudents();
        }

        private void AddStudent()
        {
            _students.Add(new Student(nameTB.Text, surnameTB.Text, int.Parse(ageTB.Text), facultyTB.Text));
        }

        private void UploadStudents()
        {
            foreach (Student student in _students)
            {
                dataGridDGV.Rows.Add(student.Name, student.Surname, student.Age, student.Faculty);
            }

            _students.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dataGridDGV.Rows.RemoveAt(0);
            }
        }

        private void dataGridDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Clicks == 2)
            {
                
            }
        }
    }
}