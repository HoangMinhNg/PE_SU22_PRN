namespace PRN211
{
    partial class Create
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
            txtBranchName = new TextBox();
            txtAccountName = new TextBox();
            txtAccountID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCreate = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(150, 125);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(179, 27);
            txtBranchName.TabIndex = 35;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(150, 80);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(179, 27);
            txtAccountName.TabIndex = 33;
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(150, 35);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(179, 27);
            txtAccountID.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 170);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 31;
            label5.Text = "Type ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 30;
            label4.Text = "Branch Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 28;
            label2.Text = "Account Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 27;
            label1.Text = "Account ID";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(235, 289);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 37;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AT0001", "AT0002", "AT0003", "AT0004" });
            comboBox1.Location = new Point(150, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 28);
            comboBox1.TabIndex = 38;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 348);
            Controls.Add(comboBox1);
            Controls.Add(btnCreate);
            Controls.Add(txtBranchName);
            Controls.Add(txtAccountName);
            Controls.Add(txtAccountID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Create";
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBranchName;
        private TextBox txtAccountName;
        private TextBox txtAccountID;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnCreate;
        private ComboBox comboBox1;
    }
}