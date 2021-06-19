using App1.SQL;
using System;
using System.Windows.Forms;

namespace App1.Forms
{
    public partial class LoginForm : Form
    {
        // переменная для работы с бд
        private SQLManager SQLManager = new SQLManager();

        // переменная-флажок отвечающая за вход под админом
        private bool isAdmin = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        // вход (с логином и паролем)
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            string sql;

            if (isAdmin)
            {
                sql = $"SELECT CODE_admpass, password from admin_pass WHERE login = '{login}'";
                int adminLoginCode = SQLManager.GetIntValue(sql, 0);
                string adminPassword = SQLManager.GetStringValue(sql, 1);

                if (adminLoginCode == -1)
                {
                    MessageBox.Show("Неправильный логин админа", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(password) || password != adminPassword)
                {
                    MessageBox.Show("Неправильный пароль админа", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                AdminForm adminForm = new AdminForm(this);
                adminForm.Show();
                this.Hide();
                return;
            }

            sql = $"SELECT password from client_pass WHERE login = '{login}'";
            string clientPassword = SQLManager.GetStringValue(sql, 0);
            sql = $"SELECT CODE_CL from Client WHERE TELEFON_CL = '{login}'";
            int clientCode = SQLManager.GetIntValue(sql, 0);

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

        // выбор роли админа
        private void adminRoleBtn_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            isAdmin = true;
        }

        // выбор роли клиента
        private void clientRoleBtn_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            isAdmin = false;
        }

        // обновление окна входа
        public void SwitchVisible()
        {
            groupBox2.Visible = !groupBox2.Visible;
            groupBox1.Visible = !groupBox1.Visible;
            loginTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}
