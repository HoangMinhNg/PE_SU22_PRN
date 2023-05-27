using ClassLibrary1.Models;
using ClassLibrary1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211
{
    public partial class Create : Form
    {
        BankAccountRepository bankAccount = new BankAccountRepository();
        AccountTypeRepository accountType = new AccountTypeRepository();


        public Create()
        {
            InitializeComponent();
            var listAccountType = accountType.getAll();
            comboBox1.DataSource = listAccountType;
            comboBox1.ValueMember = "TypeId";
            comboBox1.Refresh();
        }


        private void loadTypeID()
        {

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAccountID.Text) ||
                string.IsNullOrEmpty(txtAccountName.Text) ||
                string.IsNullOrEmpty(txtBranchName.Text) ||
                comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    bool check = Utils.checkRegex(txtAccountID.Text);
                    if (check)
                    {
                        BankAccount account = new BankAccount
                        {
                            AccountId = txtAccountID.Text,
                            AccountName = txtAccountName.Text,
                            OpenDate = DateTime.Now,
                            BranchName = txtBranchName.Text,
                            TypeId = comboBox1.SelectedItem.ToString()
                        };

                        bool result = bankAccount.Create(account);
                        if (result)
                        {
                            DialogResult res = MessageBox.Show("Create new Account successfully", "Notice", MessageBoxButtons.OK);
                            if (res == DialogResult.OK)
                            {
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID", "Warning", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input", "Warning", MessageBoxButtons.OK);
            }            
        }
    }
}
