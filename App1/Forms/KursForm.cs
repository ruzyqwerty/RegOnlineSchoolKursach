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
    public partial class KursForm : Form
    {
        private SQLManager SQLManager = new SQLManager();

        private int currentKurs = -1;

        public KursForm()
        {
            InitializeComponent();
        }

        public KursForm(int kursId)
        {
            InitializeComponent();

            currentKurs = kursId;
        }

        private void KursForm_Load(object sender, EventArgs e)
        {
            if (currentKurs == -1)
                UpdateAddForm();
            else UpdateEditForm();
        }

        private void UpdateAddForm()
        {
            string sql = $"SELECT NAME_ORG from Organizatsia";
            List<string> orgNames = SQLManager.GetStringValues(sql);

            orgNameComboBox.Items.Clear();

            foreach (string name in orgNames)
            {
                orgNameComboBox.Items.Add(name);
            }

            orgNameComboBox.SelectedIndex = 0;

            sql = $"SELECT IMYA_PD from Prepodavateli";
            List<string> prepodImyas = SQLManager.GetStringValues(sql);

            sql = $"SELECT FAM_PD from Prepodavateli";
            List<string> prepodFams = SQLManager.GetStringValues(sql);

            sql = $"SELECT OTCH_PD from Prepodavateli";
            List<string> prepodOtchs = SQLManager.GetStringValues(sql);

            prepodNameComboBox.Items.Clear();

            for (int i = 0; i < prepodImyas.Count; i++)
            {
                prepodNameComboBox.Items.Add($"{prepodFams[i]} {prepodImyas[i]} {prepodOtchs[i]}");
            }

            prepodNameComboBox.SelectedIndex = 0;

            AcceptBtn.Text = "Добавить";
        }

        private void UpdateEditForm()
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (currentKurs == -1)
                AddKurs();
            else
                EditKurs();
            this.Close();
        }

        private void AddKurs()
        {
            string sql = $"SELECT CODE_ORG from Organizatsia WHERE NAME_ORG = '{orgNameComboBox.SelectedItem}'";
            int orgId = SQLManager.GetIntValue(sql, 0);

            string fam = prepodNameComboBox.SelectedItem.ToString().Split(' ')[0];
            string name = prepodNameComboBox.SelectedItem.ToString().Split(' ')[1];
            //string otch = prepodNameComboBox.SelectedItem.ToString().Split(' ')[2];
            sql = $"SELECT CODE_PD from Prepodavateli WHERE FAM_PD = '{fam}' AND IMYA_PD = '{name}'";
            int prepodId = SQLManager.GetIntValue(sql, 0);

            sql = "INSERT INTO Kurs (CODE_ORG, CODE_PD, NAME_KURS, CHASOV, PRICE) " +
                 $"VALUES ({orgId}, {prepodId}, '{kursNameTextBox.Text}', {chasovNumUD.Value}, {priceNumUD.Value})";

            MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

            SQLManager.ExecuteSQLCommand(sql);
        }

        private void EditKurs()
        {

        }
    }
}
