using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App1.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login =  loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (login == "admin" && password == "admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Close();
                return;
            }
        }
    }
}
