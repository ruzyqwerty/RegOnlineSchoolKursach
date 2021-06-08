using App1.SQL;
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
        private SQLManager SQLManager = new SQLManager();
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
                this.Hide();
                return;
            }

            string sql = $"SELECT CODE_CL from Client WHERE NOMER_PASP_CL = '{login}'";
            int clientCode = SQLManager.GetIntValue(sql, 0);

            if (clientCode == -1)
            {
                MessageBox.Show("Неправильный логин", "Ошибка", MessageBoxButtons.OK);
                return;
            } 

            if (string.IsNullOrEmpty(password))
            {
                //MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK);
                //return;
            }


            ClientForm clientForm = new ClientForm(clientCode);
            clientForm.Show();
            this.Hide();
        }
    }
}
