using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using ClassLibrary1.Models;
using ClassLibrary1.Repository;

namespace PRN211
{
    public partial class management : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();  
        BankAccountRepository context = new BankAccountRepository();
        AccountTypeRepository accountTypeRepository = new AccountTypeRepository();
        public management()
        {
            InitializeComponent();
            var listBankAccount = context.getAll();
            for (int i = 0; i < listBankAccount.Count; i++)
            {
                var account = new BankAccount();
                account.AccountId = listBankAccount[i].AccountId;
                account.AccountName = listBankAccount[i].AccountName;
                account.OpenDate = listBankAccount[i].OpenDate;
                account.BranchName = listBankAccount[i].BranchName;
                account.TypeId = listBankAccount[i].TypeId;
                
                var type = accountTypeRepository.getAll().Where(x => x.TypeId.Contains(account.TypeId)).ToList();
                account.Type = type.FirstOrDefault();

                bankAccounts.Add(account);
            }
            dataGridView1.DataSource = new BindingSource() { DataSource = bankAccounts };
        }



        private void crStudent_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var student = new student();
            //    student.Id = students[students.Count() - 1].Id + 1;
            //    student.Name = Utils.getString(txtName.Text);
            //    student.Age = Utils.getAge(int.Parse(txtAge.Text));
            //    student.description = Utils.getString(txtDes.Text);
            //    student.phone = Utils.IsValidPhoneNumber(txtPhone.Text);
            //    student.email = Utils.IsValidEmail(txtEmail.Text);
            //    student.Created = DateTime.Now;
            //    if (student.Name == null || student.Age < 0 || student.description == null || student.phone == null || student.email == null)
            //    {
            //        MessageBox.Show("Invalid input", "Warning", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        students.Add(student);
            //        dataGridView1.DataSource = new BindingSource()
            //        {
            //            DataSource = students
            //        };
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid input", "Warning", MessageBoxButtons.OK);
            //}

            Form crForm = new Create();
            crForm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var account = bankAccount.getAll().ToList()[dataGridView1.CurrentRow.Index];
            //txtAccountID.Text = account.AccountId;
            //txtAccountName.Text = account.AccountName;
            //txtBranchName.Text = account.BranchName;
            //txtOpenDate.Text = account.OpenDate.ToString();
            //txtTypeID.Text = account.TypeId;
        }

        private void update_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int id = dataGridView1.CurrentCell.RowIndex;
            //    var student = students[id];
            //    student.Name = Utils.getString(txtName.Text);
            //    student.Age = Utils.getAge(int.Parse(txtAge.Text));
            //    student.description = Utils.getString(txtDes.Text);
            //    student.phone = Utils.IsValidPhoneNumber(txtPhone.Text);
            //    student.email = Utils.IsValidEmail(txtEmail.Text);
            //    student.Created = DateTime.Now;
            //    if (student.Name == null || student.Age < 0 || student.description == null || student.phone == null || student.email == null)
            //    {
            //        MessageBox.Show("Invalid input", "Warning", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        dataGridView1.DataSource = new BindingSource()
            //        {
            //            DataSource = students
            //        };
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid input", "Warning", MessageBoxButtons.OK);
            //}

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var account = context.getAll().ToList()[dataGridView1.CurrentRow.Index];
                DialogResult result = MessageBox.Show("Are you sure want to delete", "Notice", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    context.Delete(account);
                    dataGridView1.DataSource = new BindingSource() { DataSource = context.getAll() };
                }

                //int id = dataGridView1.CurrentCell.RowIndex;
                //var student = students[id];
                //DialogResult result = MessageBox.Show("Are you sure want to delete", "Notice", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                //{
                //    students.Remove(student);
                //    dataGridView1.DataSource = new BindingSource()
                //    {
                //        DataSource = students
                //    };
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose student to delete", "Notification", MessageBoxButtons.OK);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All field must not empty\n" +
                "ID must be a natural number \n" +
                "Age must be a possitive number\n" +
                "Lenght of phone number must bettween 10 and 11\n" +
                "Email does not contain special character", "Rules", MessageBoxButtons.OK);
        }

        private void loadUserByName(string search)
        {
            var acount = context.getAll().Where(x => x.AccountName.ToLower().Contains(search.ToLower())).ToList();
            dataGridView1.DataSource = new BindingSource() { DataSource = acount };
        }

        private void search_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            loadUserByName(search);
        }
    }
}