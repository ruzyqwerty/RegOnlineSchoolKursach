using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using App1.SQL;
using System.Windows.Forms;

namespace App1.Forms
{
    public partial class ClientForm : Form
    {
        private SQLManager SQLManager = new SQLManager();

        private int currentClient;

        public ClientForm(int clientId)
        {
            InitializeComponent();

            currentClient = clientId;

            kursTable.ReadOnly = true;
            dogovorTable.ReadOnly = true;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = SQLManager.GetDataTable("Kurs");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];

                string sql = $"SELECT NAME_ORG from Organizatsia WHERE CODE_ORG = {row["CODE_ORG"]}";
                string orgName = SQLManager.GetStringValue(sql, 0);

                sql = $"SELECT FAM_PD, IMYA_PD, OTCH_PD from Prepodavateli WHERE CODE_PD = {row["CODE_PD"]}";
                string prepodFam = SQLManager.GetStringValue(sql, 0);
                string prepodName = SQLManager.GetStringValue(sql, 1);
                string prepodOtch = SQLManager.GetStringValue(sql, 2);

                kursTable.Rows.Add();

                kursTable.Rows[i].Cells[0].Value = $"Курс {row["NAME_KURS"]}";
                kursTable.Rows[i].Cells[1].Value = $"{prepodFam} {prepodName} {prepodOtch}";
                kursTable.Rows[i].Cells[2].Value = orgName;
                kursTable.Rows[i].Cells[3].Value = row["CHASOV"];
                kursTable.Rows[i].Cells[4].Value = row["PRICE"];

            }
        }

        private void oformitDogovor_Click(object sender, EventArgs e)
        {
            string kursName = kursTable.SelectedRows[0].Cells[0].Value.ToString();

            string sql = $"SELECT CODE_CY from Kurs WHERE NAME_KURS = '{kursName.Remove(0, 5)}'";
            int kursId = SQLManager.GetIntValue(sql, 0);

            DogovorForm dogovorForm = new DogovorForm(currentClient, kursId);
            dogovorForm.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDogovorTable();
        }

        private void UpdateDogovorTable()
        {
            dogovorTable.Rows.Clear();

            DataTable dataTable = SQLManager.GetDataTable("Dogovor");

            int count = 0;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];

                if (row["CODE_CL"].ToString() != currentClient.ToString())
                    continue;


                string sql = $"SELECT NAME_ORG from Organizatsia WHERE CODE_ORG = {row["CODE_ORG"]}";
                string orgName = SQLManager.GetStringValue(sql, 0);

                sql = $"SELECT NAME_KURS, PRICE from Kurs WHERE CODE_CY = {row["CODE_CY"]}";
                string kursName = SQLManager.GetStringValue(sql, 0);
                decimal price = SQLManager.GetMoneyValue(sql, 1);

                dogovorTable.Rows.Add();

                dogovorTable.Rows[count].Cells[0].Value = kursName;
                dogovorTable.Rows[count].Cells[1].Value = orgName;
                dogovorTable.Rows[count].Cells[2].Value = price.ToString();
                dogovorTable.Rows[count].Cells[3].Value = row["DATA"].ToString().Split(' ')[0];

                count += 1;
            }
        }
    }
}
