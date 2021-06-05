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
    public partial class DogovorForm : Form
    {
        public DogovorForm(int clientId, int kursId)
        {
            InitializeComponent();

            //вывести инфу пользователю


            kursNameText.Text = kursId.ToString();
        }

        private void DogovorForm_Load(object sender, EventArgs e)
        {
            //добавить договор в бд
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
