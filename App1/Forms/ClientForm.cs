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

        private string currentClient;

        public ClientForm()
        {
            InitializeComponent();
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

                kursTable.Rows[i].Cells[0].Value = row["NAME_KURS"];
                kursTable.Rows[i].Cells[1].Value = $"{prepodFam} {prepodName} {prepodOtch}";
                kursTable.Rows[i].Cells[2].Value = orgName;
                kursTable.Rows[i].Cells[3].Value = row["CHASOV"];
                kursTable.Rows[i].Cells[4].Value = row["PRICE"];

            }
        }

        private void oformitDogovor_Click(object sender, EventArgs e)
        {
            DogovorForm dogovorForm = new DogovorForm(1, 1);
            dogovorForm.ShowDialog();
        }
    }
}
