using App1.SQL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App1.Forms
{
    public partial class EditDogovorForm : Form
    {
        private int currentDogovor = -1;
        private SQLManager SQLManager = new SQLManager();

        public EditDogovorForm(int dogovorId)
        {
            InitializeComponent();

            currentDogovor = dogovorId;

            UpdateForm();
        }

        private void UpdateForm()
        {
            string sql = $"SELECT CODE_ORG, CODE_CL, CODE_CY, DATA from Dogovor WHERE CODE_DOG = {currentDogovor}";
            int orgCode = SQLManager.GetIntValue(sql, 0);
            int clientCode = SQLManager.GetIntValue(sql, 1);
            int kursCode = SQLManager.GetIntValue(sql, 2);
            DateTime date = SQLManager.GetDataTimeValue(sql, 3);

            sql = $"SELECT NAME_KURS from Kurs WHERE CODE_CY = {kursCode}";
            string kursName = SQLManager.GetStringValue(sql, 0);


            sql = $"SELECT NAME_KURS from Kurs";
            List<string> kursNames = SQLManager.GetStringValues(sql);

            kursNameComboBox.Items.Clear();

            foreach (string name in kursNames)
            {
                kursNameComboBox.Items.Add(name);
            }

            kursNameComboBox.SelectedItem = kursName;

            sql = $"SELECT IMYA_CL from Client";
            List<string> clientsImyas = SQLManager.GetStringValues(sql);

            sql = $"SELECT FAM_CL from Client";
            List<string> clientsFams = SQLManager.GetStringValues(sql);

            sql = $"SELECT OTCH_CL from Client";
            List<string> clientsOtchs = SQLManager.GetStringValues(sql);

            sql = $"SELECT FAM_CL, IMYA_CL, OTCH_CL from Client WHERE CODE_CL = {clientCode}";
            string clientFam = SQLManager.GetStringValue(sql, 0);
            string clientImya = SQLManager.GetStringValue(sql, 1);
            string clientOtch = SQLManager.GetStringValue(sql, 2);


            clientNameComboBox.Items.Clear();

            for (int i = 0; i < clientsImyas.Count; i++)
            {
                clientNameComboBox.Items.Add($"{clientsFams[i]} {clientsImyas[i]} {clientsOtchs[i]}");
            }

            clientNameComboBox.SelectedItem = $"{clientFam} {clientImya} {clientOtch}";

            sql = $"SELECT NAME_ORG from Organizatsia WHERE CODE_ORG = {orgCode}";
            string orgName = SQLManager.GetStringValue(sql, 0);


            sql = $"SELECT NAME_ORG from Organizatsia";
            List<string> orgNames = SQLManager.GetStringValues(sql);

            orgNameComboBox.Items.Clear();

            foreach (string name in orgNames)
            {
                orgNameComboBox.Items.Add(name);
            }

            orgNameComboBox.SelectedItem = orgName;

            dataCreateCalendar.SetDate(date);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT CODE_ORG from Organizatsia WHERE NAME_ORG = '{orgNameComboBox.SelectedItem}'";
            int orgId = SQLManager.GetIntValue(sql, 0);

            string fam = clientNameComboBox.SelectedItem.ToString().Split(' ')[0];
            string name = clientNameComboBox.SelectedItem.ToString().Split(' ')[1];

            sql = $"SELECT CODE_CL from Client WHERE FAM_CL = '{fam}' AND IMYA_CL = '{name}'";
            int clientId = SQLManager.GetIntValue(sql, 0);

            sql = $"SELECT CODE_CY from Kurs WHERE NAME_KURS = '{kursNameComboBox.SelectedItem}'";
            int kursId = SQLManager.GetIntValue(sql, 0);


            sql = $"UPDATE Dogovor SET CODE_ORG = {orgId} WHERE CODE_DOG = {currentDogovor};";
            SQLManager.ExecuteSQLCommand(sql);
            sql = $"UPDATE Dogovor SET CODE_CL = {clientId} WHERE CODE_DOG = {currentDogovor};";
            SQLManager.ExecuteSQLCommand(sql);
            sql = $"UPDATE Dogovor SET CODE_CY = '{kursId}' WHERE CODE_DOG = {currentDogovor};";
            SQLManager.ExecuteSQLCommand(sql);
            DateTime date = dataCreateCalendar.SelectionRange.Start;
            sql = $"UPDATE Dogovor SET DATA = '{date:yyyy-MM-dd}' WHERE CODE_DOG = {currentDogovor};";
            SQLManager.ExecuteSQLCommand(sql);

            Close();
        }
    }
}
