namespace DGW_Practice_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridDGV = new DataGridView();
            StudentName = new DataGridViewTextBoxColumn();
            StudentSurname = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Faculty = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nameTB = new TextBox();
            surnameTB = new TextBox();
            ageTB = new TextBox();
            facultyTB = new TextBox();
            AddStudentBTN = new Button();
            showStudentsBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridDGV).BeginInit();
            SuspendLayout();
            // 
            // dataGridDGV
            // 
            dataGridDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDGV.Columns.AddRange(new DataGridViewColumn[] { StudentName, StudentSurname, Age, Faculty });
            dataGridDGV.Location = new Point(12, 12);
            dataGridDGV.Name = "dataGridDGV";
            dataGridDGV.RowTemplate.Height = 25;
            dataGridDGV.Size = new Size(444, 150);
            dataGridDGV.TabIndex = 0;
            dataGridDGV.CellMouseDoubleClick += dataGridDGV_CellMouseDoubleClick;
            dataGridDGV.KeyDown += dataGridDGV_KeyDown;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Имя студента ";
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // StudentSurname
            // 
            StudentSurname.HeaderText = "Фамилия студента";
            StudentSurname.Name = "StudentSurname";
            StudentSurname.ReadOnly = true;
            // 
            // Age
            // 
            Age.HeaderText = "Возраст";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Faculty
            // 
            Faculty.HeaderText = "Факультет";
            Faculty.Name = "Faculty";
            Faculty.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(599, 39);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 100);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 158);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Возраст";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(599, 216);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 4;
            label4.Text = "Факультет";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(600, 65);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(100, 23);
            nameTB.TabIndex = 5;
            // 
            // surnameTB
            // 
            surnameTB.Location = new Point(600, 126);
            surnameTB.Name = "surnameTB";
            surnameTB.Size = new Size(100, 23);
            surnameTB.TabIndex = 6;
            // 
            // ageTB
            // 
            ageTB.Location = new Point(601, 185);
            ageTB.Name = "ageTB";
            ageTB.Size = new Size(100, 23);
            ageTB.TabIndex = 7;
            // 
            // facultyTB
            // 
            facultyTB.Location = new Point(599, 246);
            facultyTB.Name = "facultyTB";
            facultyTB.Size = new Size(100, 23);
            facultyTB.TabIndex = 8;
            // 
            // AddStudentBTN
            // 
            AddStudentBTN.Location = new Point(599, 291);
            AddStudentBTN.Name = "AddStudentBTN";
            AddStudentBTN.Size = new Size(135, 31);
            AddStudentBTN.TabIndex = 9;
            AddStudentBTN.Text = "Добавить студента";
            AddStudentBTN.UseVisualStyleBackColor = true;
            AddStudentBTN.Click += AddStudentBTN_Click;
            // 
            // showStudentsBTN
            // 
            showStudentsBTN.Location = new Point(611, 341);
            showStudentsBTN.Name = "showStudentsBTN";
            showStudentsBTN.Size = new Size(123, 44);
            showStudentsBTN.TabIndex = 10;
            showStudentsBTN.Text = "Вывести список студентов";
            showStudentsBTN.UseVisualStyleBackColor = true;
            showStudentsBTN.Click += showStudentsBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 496);
            Controls.Add(showStudentsBTN);
            Controls.Add(AddStudentBTN);
            Controls.Add(facultyTB);
            Controls.Add(ageTB);
            Controls.Add(surnameTB);
            Controls.Add(nameTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridDGV);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridDGV;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn StudentSurname;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Faculty;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTB;
        private TextBox surnameTB;
        private TextBox ageTB;
        private TextBox facultyTB;
        private Button AddStudentBTN;
        private Button showStudentsBTN;
    }
}