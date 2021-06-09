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

        private bool isAdmin = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login =  loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (isAdmin)
            {
                if (login != "admin")
                {
                    MessageBox.Show("Неправильный логин адмиина", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
                if (password != "admin")
                {
                    MessageBox.Show("Неправильный пароль админа", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                AdminForm adminForm = new AdminForm(this);
                adminForm.Show();
                this.Hide();
                return;
            }

            string sql = $"SELECT CODE_CL, PASSWORD_CL from Client WHERE NOMER_PASP_CL = '{login}'";
            int clientCode = SQLManager.GetIntValue(sql, 0);
            string clientPassword = SQLManager.GetStringValue(sql, 1);

            if (clientCode == -1)
            {
                MessageBox.Show("Неправильный логин", "Ошибка", MessageBoxButtons.OK);
                return;
            } 

            if (string.IsNullOrEmpty(password) || password != clientPassword)
            {
                MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK);
                return;
            }


            ClientForm clientForm = new ClientForm(clientCode, this);
            clientForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void adminRoleBtn_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            isAdmin = true;
        }

        private void clientRoleBtn_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            isAdmin = false;
        }

        public void SwitchVisible()
        {
            groupBox2.Visible = !groupBox2.Visible;
            groupBox1.Visible = !groupBox1.Visible;
            loginTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}
