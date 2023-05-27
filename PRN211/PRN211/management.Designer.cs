namespace PRN211
{
    partial class management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            crStudent = new Button();
            update = new Button();
            btnDelete = new Button();
            button1 = new Button();
            txtSearch = new TextBox();
            search = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // crStudent
            // 
            crStudent.Location = new Point(12, 278);
            crStudent.Margin = new Padding(3, 4, 3, 4);
            crStudent.Name = "crStudent";
            crStudent.Size = new Size(174, 41);
            crStudent.TabIndex = 1;
            crStudent.Text = "Create";
            crStudent.UseVisualStyleBackColor = true;
            crStudent.Click += crStudent_Click;
            // 
            // update
            // 
            update.Location = new Point(442, 278);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(174, 41);
            update.TabIndex = 6;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(236, 278);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 41);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(740, 485);
            button1.Name = "button1";
            button1.Size = new Size(145, 42);
            button1.TabIndex = 14;
            button1.Text = "Guideline";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(624, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 27);
            txtSearch.TabIndex = 15;
            // 
            // search
            // 
            search.Location = new Point(791, 2);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 16;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(873, 234);
            dataGridView1.TabIndex = 17;
            // 
            // management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 539);
            Controls.Add(dataGridView1);
            Controls.Add(search);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(update);
            Controls.Add(crStudent);
            Name = "management";
            Text = "management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button crStudent;
        private Button update;
        private Button btnDelete;
        private Button button1;
        private TextBox txtSearch;
        private Button search;
        private DataGridView dataGridView1;
    }
}