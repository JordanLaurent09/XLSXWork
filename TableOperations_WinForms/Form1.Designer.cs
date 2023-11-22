namespace TableOperations_WinForms
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
            Usernames = new DataGridViewTextBoxColumn();
            UserSurnames = new DataGridViewTextBoxColumn();
            Ages = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridDGV).BeginInit();
            SuspendLayout();
            // 
            // DataGridDGV
            // 
            DataGridDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridDGV.Columns.AddRange(new DataGridViewColumn[] { Usernames, UserSurnames, Ages });
            DataGridDGV.Location = new Point(70, 12);
            DataGridDGV.Name = "DataGridDGV";
            DataGridDGV.RowTemplate.Height = 25;
            DataGridDGV.Size = new Size(444, 462);
            DataGridDGV.TabIndex = 0;
            // 
            // Usernames
            // 
            Usernames.HeaderText = "Имена пользователей";
            Usernames.Name = "Usernames";
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
            label1.Location = new Point(713, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(723, 138);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(723, 236);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(692, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(539, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(702, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(692, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 691);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private DataGridViewTextBoxColumn Usernames;
        private DataGridViewTextBoxColumn UserSurnames;
        private DataGridViewTextBoxColumn Ages;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}