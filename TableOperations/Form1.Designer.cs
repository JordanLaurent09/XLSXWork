namespace TableOperations
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
            DataGridDGV = new DataGridView();
            UserNames = new DataGridViewTextBoxColumn();
            UserSurnames = new DataGridViewTextBoxColumn();
            Ages = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userNameTB = new TextBox();
            userSurnameTB = new TextBox();
            userAgeTB = new TextBox();
            AddBTN = new Button();
            UploadListBTN = new Button();
            AddColumnBTN = new Button();
            columnNameTB = new TextBox();
            columnTextTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridDGV).BeginInit();
            SuspendLayout();
            // 
            // DataGridDGV
            // 
            DataGridDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridDGV.Columns.AddRange(new DataGridViewColumn[] { UserNames, UserSurnames, Ages });
            DataGridDGV.Location = new Point(56, 41);
            DataGridDGV.Name = "DataGridDGV";
            DataGridDGV.RowTemplate.Height = 25;
            DataGridDGV.Size = new Size(340, 335);
            DataGridDGV.TabIndex = 0;
            DataGridDGV.KeyDown += DataGridDGV_KeyDown;
            // 
            // UserNames
            // 
            UserNames.HeaderText = "Имена пользователей";
            UserNames.Name = "UserNames";
            UserNames.ReadOnly = true;
            // 
            // UserSurnames
            // 
            UserSurnames.HeaderText = "Фамилии пользователей";
            UserSurnames.Name = "UserSurnames";
            UserSurnames.ReadOnly = true;
            // 
            // Ages
            // 
            Ages.HeaderText = "Возраст";
            Ages.Name = "Ages";
            Ages.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 41);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 101);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 157);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Возраст";
            // 
            // userNameTB
            // 
            userNameTB.Location = new Point(544, 59);
            userNameTB.Name = "userNameTB";
            userNameTB.Size = new Size(100, 23);
            userNameTB.TabIndex = 4;
            // 
            // userSurnameTB
            // 
            userSurnameTB.Location = new Point(544, 119);
            userSurnameTB.Name = "userSurnameTB";
            userSurnameTB.Size = new Size(100, 23);
            userSurnameTB.TabIndex = 5;
            // 
            // userAgeTB
            // 
            userAgeTB.Location = new Point(544, 185);
            userAgeTB.Name = "userAgeTB";
            userAgeTB.Size = new Size(100, 23);
            userAgeTB.TabIndex = 6;
            // 
            // AddBTN
            // 
            AddBTN.Location = new Point(544, 214);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(75, 23);
            AddBTN.TabIndex = 7;
            AddBTN.Text = "Добавить";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // UploadListBTN
            // 
            UploadListBTN.Location = new Point(544, 243);
            UploadListBTN.Name = "UploadListBTN";
            UploadListBTN.Size = new Size(122, 57);
            UploadListBTN.TabIndex = 8;
            UploadListBTN.Text = "Выгрузить список";
            UploadListBTN.UseVisualStyleBackColor = true;
            UploadListBTN.Click += UploadListBTN_Click;
            // 
            // AddColumnBTN
            // 
            AddColumnBTN.Location = new Point(678, 375);
            AddColumnBTN.Name = "AddColumnBTN";
            AddColumnBTN.Size = new Size(75, 64);
            AddColumnBTN.TabIndex = 9;
            AddColumnBTN.UseVisualStyleBackColor = true;
            AddColumnBTN.Click += AddColumnBTN_Click;
            // 
            // columnNameTB
            // 
            columnNameTB.Location = new Point(464, 374);
            columnNameTB.Name = "columnNameTB";
            columnNameTB.Size = new Size(165, 23);
            columnNameTB.TabIndex = 10;
            // 
            // columnTextTB
            // 
            columnTextTB.Location = new Point(464, 416);
            columnTextTB.Name = "columnTextTB";
            columnTextTB.Size = new Size(165, 23);
            columnTextTB.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(columnTextTB);
            Controls.Add(columnNameTB);
            Controls.Add(AddColumnBTN);
            Controls.Add(UploadListBTN);
            Controls.Add(AddBTN);
            Controls.Add(userAgeTB);
            Controls.Add(userSurnameTB);
            Controls.Add(userNameTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DataGridDGV);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGridDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridDGV;
        private DataGridViewTextBoxColumn UserNames;
        private DataGridViewTextBoxColumn UserSurnames;
        private DataGridViewTextBoxColumn Ages;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userNameTB;
        private TextBox userSurnameTB;
        private TextBox userAgeTB;
        private Button AddBTN;
        private Button UploadListBTN;
        private Button AddColumnBTN;
        private TextBox columnNameTB;
        private TextBox columnTextTB;
    }
}