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
            ((System.ComponentModel.ISupportInitialize)DataGridDGV).BeginInit();
            SuspendLayout();
            // 
            // DataGridDGV
            // 
            DataGridDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridDGV.Location = new Point(26, 32);
            DataGridDGV.Name = "DataGridDGV";
            DataGridDGV.RowTemplate.Height = 25;
            DataGridDGV.Size = new Size(240, 150);
            DataGridDGV.TabIndex = 0;
            // 
            // OpenFileBTN
            // 
            OpenFileBTN.Location = new Point(47, 305);
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
            ShowCsvFilesCB.Location = new Point(453, 135);
            ShowCsvFilesCB.Name = "ShowCsvFilesCB";
            ShowCsvFilesCB.Size = new Size(121, 23);
            ShowCsvFilesCB.TabIndex = 2;
            ShowCsvFilesCB.SelectedIndexChanged += ShowCsvFilesCB_SelectedIndexChanged;
            // 
            // FileNameTB
            // 
            FileNameTB.Location = new Point(87, 230);
            FileNameTB.Name = "FileNameTB";
            FileNameTB.Size = new Size(100, 23);
            FileNameTB.TabIndex = 3;
            // 
            // AddFilesNameBTN
            // 
            AddFilesNameBTN.Location = new Point(478, 198);
            AddFilesNameBTN.Name = "AddFilesNameBTN";
            AddFilesNameBTN.Size = new Size(75, 55);
            AddFilesNameBTN.TabIndex = 4;
            AddFilesNameBTN.Text = "Добавить файлы в список";
            AddFilesNameBTN.UseVisualStyleBackColor = true;
            AddFilesNameBTN.Click += AddFilesNameBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}