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
    public partial class Login : Form
    {
        private UserRepository userRepository = new UserRepository();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Username can not empty", "Error", MessageBoxButtons.OK);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can not empty", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    var users = userRepository.getAll();
                    var user = users.First(x => x.UserId == txtUsername.Text);
                    if (user.UserRole == 1)
                    {
                        this.Hide();
                        Form frManagement = new management();
                        frManagement.ShowDialog();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("You are not allow to access", "Warning", MessageBoxButtons.OK);
                }
            }
        }
    }
}
