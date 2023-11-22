namespace TableOperations
{
    public partial class Form1 : Form
    {
        private List<User> _users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        
        private void UploadListBTN_Click(object sender, EventArgs e)
        {
            UploadUsers();
        }


        private void AddUser()
        {
            _users.Add(new User(userNameTB.Text, userSurnameTB.Text, int.Parse(userAgeTB.Text)));
        }

        private void UploadUsers()
        {
            foreach(User user in _users)
            {
                DataGridDGV.Rows.Add(user.Name, user.Surname, user.Age);
            }

            _users.Clear();
        }
    }
}