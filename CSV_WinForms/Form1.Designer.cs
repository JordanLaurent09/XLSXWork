namespace CSV_WinForms
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
            OpenFileBTN = new Button();
            ShowCsvFilesCB = new ComboBox();
            FileNameTB = new TextBox();
            AddFilesNameBTN = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridDGV).BeginInit();
            SuspendLayout();
            // 
            // DataGridDGV
            // 
            DataGridDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridDGV.Location = new Point(12, 12);
            DataGridDGV.Name = "DataGridDGV";
            DataGridDGV.RowTemplate.Height = 25;
            DataGridDGV.Size = new Size(534, 212);
            DataGridDGV.TabIndex = 0;
            // 
            // OpenFileBTN
            // 
            OpenFileBTN.Location = new Point(179, 331);
            OpenFileBTN.Name = "OpenFileBTN";
            OpenFileBTN.Size = new Size(198, 58);
            OpenFileBTN.TabIndex = 1;
            OpenFileBTN.Text = "Показать содержимое файла";
            OpenFileBTN.UseVisualStyleBackColor = true;
            OpenFileBTN.Click += OpenFileBTN_Click;
            // 
            // ShowCsvFilesCB
            // 
            ShowCsvFilesCB.FormattingEnabled = true;
            ShowCsvFilesCB.Location = new Point(597, 127);
            ShowCsvFilesCB.Name = "ShowCsvFilesCB";
            ShowCsvFilesCB.Size = new Size(121, 23);
            ShowCsvFilesCB.TabIndex = 2;
            ShowCsvFilesCB.SelectedIndexChanged += ShowCsvFilesCB_SelectedIndexChanged;
            // 
            // FileNameTB
            // 
            FileNameTB.Location = new Point(105, 276);
            FileNameTB.Name = "FileNameTB";
            FileNameTB.Size = new Size(349, 23);
            FileNameTB.TabIndex = 3;
            // 
            // AddFilesNameBTN
            // 
            AddFilesNameBTN.Location = new Point(624, 184);
            AddFilesNameBTN.Name = "AddFilesNameBTN";
            AddFilesNameBTN.Size = new Size(75, 55);
            AddFilesNameBTN.TabIndex = 4;
            AddFilesNameBTN.Text = "Добавить файлы в список";
            AddFilesNameBTN.UseVisualStyleBackColor = true;
            AddFilesNameBTN.Click += AddFilesNameBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 241);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 5;
            label1.Text = "Название файла";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(AddFilesNameBTN);
            Controls.Add(FileNameTB);
            Controls.Add(ShowCsvFilesCB);
            Controls.Add(OpenFileBTN);
            Controls.Add(DataGridDGV);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGridDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridDGV;
        private Button OpenFileBTN;
        private ComboBox ShowCsvFilesCB;
        private TextBox FileNameTB;
        private Button AddFilesNameBTN;
        private Label label1;
    }
}