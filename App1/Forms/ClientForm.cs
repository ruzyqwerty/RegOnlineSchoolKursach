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

        private int priceSort = 0;
        private int chasovSort = 0;

        public ClientForm(int clientId)
        {
            InitializeComponent();

            currentClient = clientId;

            kursTable.ReadOnly = true;
            dogovorTable.ReadOnly = true;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            UpdateKursTable();
            UpdateDogovorTable();
        }

        private void UpdateKursTable()
        {
            kursTable.Rows.Clear();

            string sql;

            if (priceSort != 0 && chasovSort != 0)
                sql = $"SELECT CODE_CY from Kurs WHERE PRICE < {priceSort} AND CHASOV < {chasovSort}";
            else if (priceSort != 0)
                sql = $"SELECT CODE_CY from Kurs WHERE PRICE < {priceSort}";
            else if (chasovSort != 0)
                sql = $"SELECT CODE_CY from Kurs WHERE CHASOV < {chasovSort}";
            else sql = $"SELECT CODE_CY from Kurs";

            List<int> keys = SQLManager.GetKeysValues(sql);

            int count = 0;

            foreach (int key in keys)
            {
                sql = $"SELECT CODE_ORG, CODE_PD, NAME_KURS, CHASOV, PRICE from Kurs WHERE CODE_CY = {key}";
                int orgCode = SQLManager.GetIntValue(sql, 0);
                int prepodCode = SQLManager.GetIntValue(sql, 1);
                string kursName = SQLManager.GetStringValue(sql, 2);
                int chasov = SQLManager.GetIntValue(sql, 3);
                decimal price = SQLManager.GetMoneyValue(sql, 4);

                sql = $"SELECT NAME_ORG from Organizatsia WHERE CODE_ORG = {orgCode}";
                string orgName = SQLManager.GetStringValue(sql, 0);

                sql = $"SELECT FAM_PD, IMYA_PD, OTCH_PD from Prepodavateli WHERE CODE_PD = {prepodCode}";
                string prepodFam = SQLManager.GetStringValue(sql, 0);
                string prepodName = SQLManager.GetStringValue(sql, 1);
                string prepodOtch = SQLManager.GetStringValue(sql, 2);

                kursTable.Rows.Add();

                kursTable.Rows[count].Cells[0].Value = $"Курс {kursName}";
                kursTable.Rows[count].Cells[1].Value = $"{prepodFam} {prepodName} {prepodOtch}";
                kursTable.Rows[count].Cells[2].Value = orgName;
                kursTable.Rows[count].Cells[3].Value = chasov.ToString();
                kursTable.Rows[count].Cells[4].Value = price.ToString();

                count += 1;
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
            UpdateKursTable();
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

        private void priceSortBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                priceSort = int.Parse(priceSortBox.Text);
            }
            catch (Exception ex)
            {
                priceSort = 0;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            UpdateKursTable();
        }

        private void chasovSortBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chasovSort = int.Parse(chasovSortBox.Text);
            }
            catch (Exception ex)
            {
                chasovSort = 0;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            UpdateKursTable();
        }
    }
}
