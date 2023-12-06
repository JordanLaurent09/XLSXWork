namespace WordOpsWinForm
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
            createDocBTN = new Button();
            lowerNumberTB = new TextBox();
            upperNumberTB = new TextBox();
            rowsTB = new TextBox();
            columnsTB = new TextBox();
            docNameTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // createDocBTN
            // 
            createDocBTN.Location = new Point(555, 308);
            createDocBTN.Name = "createDocBTN";
            createDocBTN.Size = new Size(104, 54);
            createDocBTN.TabIndex = 0;
            createDocBTN.Text = "Создать";
            createDocBTN.UseVisualStyleBackColor = true;
            createDocBTN.Click += createDocBTN_Click;
            // 
            // lowerNumberTB
            // 
            lowerNumberTB.Location = new Point(123, 69);
            lowerNumberTB.Name = "lowerNumberTB";
            lowerNumberTB.Size = new Size(100, 23);
            lowerNumberTB.TabIndex = 1;
            // 
            // upperNumberTB
            // 
            upperNumberTB.Location = new Point(289, 76);
            upperNumberTB.Name = "upperNumberTB";
            upperNumberTB.Size = new Size(100, 23);
            upperNumberTB.TabIndex = 2;
            // 
            // rowsTB
            // 
            rowsTB.Location = new Point(123, 133);
            rowsTB.Name = "rowsTB";
            rowsTB.Size = new Size(100, 23);
            rowsTB.TabIndex = 3;
            // 
            // columnsTB
            // 
            columnsTB.Location = new Point(289, 133);
            columnsTB.Name = "columnsTB";
            columnsTB.Size = new Size(100, 23);
            columnsTB.TabIndex = 4;
            // 
            // docNameTB
            // 
            docNameTB.Location = new Point(200, 304);
            docNameTB.Name = "docNameTB";
            docNameTB.Size = new Size(100, 23);
            docNameTB.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 44);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 6;
            label1.Text = "От";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 51);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 7;
            label2.Text = "До";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 112);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 8;
            label3.Text = "Количество строк";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 112);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 9;
            label4.Text = "Количество колонок";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 266);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 10;
            label5.Text = "Название документа";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(docNameTB);
            Controls.Add(columnsTB);
            Controls.Add(rowsTB);
            Controls.Add(upperNumberTB);
            Controls.Add(lowerNumberTB);
            Controls.Add(createDocBTN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createDocBTN;
        private TextBox lowerNumberTB;
        private TextBox upperNumberTB;
        private TextBox rowsTB;
        private TextBox columnsTB;
        private TextBox docNameTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}