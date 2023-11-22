namespace DGV_Excel_Operations
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
            OpenXLBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridDGV).BeginInit();
            SuspendLayout();
            // 
            // dataGridDGV
            // 
            dataGridDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDGV.Location = new Point(61, 47);
            dataGridDGV.Name = "dataGridDGV";
            dataGridDGV.RowTemplate.Height = 25;
            dataGridDGV.Size = new Size(644, 362);
            dataGridDGV.TabIndex = 0;
            // 
            // OpenXLBTN
            // 
            OpenXLBTN.Location = new Point(241, 476);
            OpenXLBTN.Name = "OpenXLBTN";
            OpenXLBTN.Size = new Size(75, 23);
            OpenXLBTN.TabIndex = 1;
            OpenXLBTN.Text = "button1";
            OpenXLBTN.UseVisualStyleBackColor = true;
            OpenXLBTN.Click += OpenXLBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 612);
            Controls.Add(OpenXLBTN);
            Controls.Add(dataGridDGV);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridDGV;
        private Button OpenXLBTN;
    }
}