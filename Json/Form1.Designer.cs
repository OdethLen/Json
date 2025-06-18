namespace Json
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
            btnRead = new Button();
            dgvData = new DataGridView();
            cbFilter = new ComboBox();
            btnFilter = new Button();
            Country = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(45, 99);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(174, 99);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(483, 254);
            dgvData.TabIndex = 1;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(244, 53);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(115, 23);
            cbFilter.TabIndex = 4;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(378, 53);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // Country
            // 
            Country.AutoSize = true;
            Country.Location = new Point(174, 56);
            Country.Name = "Country";
            Country.Size = new Size(53, 15);
            Country.TabIndex = 6;
            Country.Text = "Country ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 391);
            Controls.Add(Country);
            Controls.Add(btnFilter);
            Controls.Add(cbFilter);
            Controls.Add(dgvData);
            Controls.Add(btnRead);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private DataGridView dgvData;
        private ComboBox cbFilter;
        private Button btnFilter;
        private Label Country;
    }
}
