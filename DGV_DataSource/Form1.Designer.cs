namespace DGV_DataSource
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
            uploadDataBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridDGV).BeginInit();
            SuspendLayout();
            // 
            // dataGridDGV
            // 
            dataGridDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDGV.Location = new Point(28, 25);
            dataGridDGV.Name = "dataGridDGV";
            dataGridDGV.RowTemplate.Height = 25;
            dataGridDGV.Size = new Size(844, 510);
            dataGridDGV.TabIndex = 0;
            // 
            // uploadDataBTN
            // 
            uploadDataBTN.Location = new Point(222, 588);
            uploadDataBTN.Name = "uploadDataBTN";
            uploadDataBTN.Size = new Size(147, 23);
            uploadDataBTN.TabIndex = 1;
            uploadDataBTN.Text = "Выгрузить данные";
            uploadDataBTN.UseVisualStyleBackColor = true;
            uploadDataBTN.Click += uploadDataBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 677);
            Controls.Add(uploadDataBTN);
            Controls.Add(dataGridDGV);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridDGV;
        private Button uploadDataBTN;
    }
}