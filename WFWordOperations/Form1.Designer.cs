namespace WFWordOperations
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
            label1 = new Label();
            filePathTB = new TextBox();
            label2 = new Label();
            paragraphTB = new TextBox();
            textBoldnessCB = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            fontStyleCMB = new ComboBox();
            fontColorCMB = new ComboBox();
            textSizeTB = new TextBox();
            addParagraphBTN = new Button();
            saveBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Путь к файлу";
            // 
            // filePathTB
            // 
            filePathTB.Location = new Point(63, 51);
            filePathTB.Name = "filePathTB";
            filePathTB.Size = new Size(358, 23);
            filePathTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 105);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Параграф";
            // 
            // paragraphTB
            // 
            paragraphTB.Location = new Point(67, 144);
            paragraphTB.Multiline = true;
            paragraphTB.Name = "paragraphTB";
            paragraphTB.Size = new Size(354, 381);
            paragraphTB.TabIndex = 3;
            // 
            // textBoldnessCB
            // 
            textBoldnessCB.AutoSize = true;
            textBoldnessCB.Location = new Point(548, 53);
            textBoldnessCB.Name = "textBoldnessCB";
            textBoldnessCB.Size = new Size(74, 19);
            textBoldnessCB.TabIndex = 4;
            textBoldnessCB.Text = "Жирный";
            textBoldnessCB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 105);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Шрифт";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 160);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Цвет";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(554, 224);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 7;
            label5.Text = "Размер";
            // 
            // fontStyleCMB
            // 
            fontStyleCMB.FormattingEnabled = true;
            fontStyleCMB.Location = new Point(552, 125);
            fontStyleCMB.Name = "fontStyleCMB";
            fontStyleCMB.Size = new Size(121, 23);
            fontStyleCMB.TabIndex = 8;
            // 
            // fontColorCMB
            // 
            fontColorCMB.FormattingEnabled = true;
            fontColorCMB.Location = new Point(552, 178);
            fontColorCMB.Name = "fontColorCMB";
            fontColorCMB.Size = new Size(121, 23);
            fontColorCMB.TabIndex = 9;
            // 
            // textSizeTB
            // 
            textSizeTB.Location = new Point(552, 242);
            textSizeTB.Name = "textSizeTB";
            textSizeTB.Size = new Size(119, 23);
            textSizeTB.TabIndex = 10;
            // 
            // addParagraphBTN
            // 
            addParagraphBTN.Location = new Point(548, 300);
            addParagraphBTN.Name = "addParagraphBTN";
            addParagraphBTN.Size = new Size(171, 67);
            addParagraphBTN.TabIndex = 11;
            addParagraphBTN.Text = "Добавить параграф";
            addParagraphBTN.UseVisualStyleBackColor = true;
            addParagraphBTN.Click += addParagraphBTN_Click;
            // 
            // saveBTN
            // 
            saveBTN.Location = new Point(897, 532);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new Size(194, 101);
            saveBTN.TabIndex = 12;
            saveBTN.Text = "Сохранить";
            saveBTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 645);
            Controls.Add(saveBTN);
            Controls.Add(addParagraphBTN);
            Controls.Add(textSizeTB);
            Controls.Add(fontColorCMB);
            Controls.Add(fontStyleCMB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoldnessCB);
            Controls.Add(paragraphTB);
            Controls.Add(label2);
            Controls.Add(filePathTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox filePathTB;
        private Label label2;
        private TextBox paragraphTB;
        private CheckBox textBoldnessCB;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox fontStyleCMB;
        private ComboBox fontColorCMB;
        private TextBox textSizeTB;
        private Button addParagraphBTN;
        private Button saveBTN;
    }
}