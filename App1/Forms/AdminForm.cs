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
    public partial class AdminForm : Form
    {
        private SQLManager SQLManager = new SQLManager();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            clientsTable.Columns[0].ReadOnly = true;
            dogovorTable.Columns[0].ReadOnly = true;
            kurssTable.Columns[0].ReadOnly = true;
            orgsTable.Columns[0].ReadOnly = true;
            prepodsTable.Columns[0].ReadOnly = true;
            historyTable.Columns[0].ReadOnly = true;

            UpdateClientTable();
            UpdateOrgsTable();
            UpdatePrepodsTable();
            UpdateKursTable();
            UpdateHistotyTable();
            UpdateDogovorTable();
        }

        private void UpdateClientTable()
        {
            clientsTable.Rows.Clear();

            DataTable dataTable = SQLManager.GetDataTable("Client");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];

                clientsTable.Rows.Add();

                clientsTable.Rows[i].Cells[0].Value = row["CODE_CL"];
                clientsTable.Rows[i].Cells[1].Value = row["IMYA_CL"];
                clientsTable.Rows[i].Cells[2].Value = row["FAM_CL"];
                clientsTable.Rows[i].Cells[3].Value = row["OTCH_CL"];
                clientsTable.Rows[i].Cells[4].Value = row["TELEFON_CL"];
                clientsTable.Rows[i].Cells[5].Value = row["NOMER_PASP_CL"];
            }
        }

        private void clientsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string sql;

            if (clientsTable[0, e.RowIndex].Value == null || string.IsNullOrWhiteSpace(clientsTable[0, e.RowIndex].Value.ToString()))
            {
                List<string> columnsNames = new List<string>();
                List<string> newData = new List<string>();

                foreach (DataGridViewCell cell in clientsTable.Rows[e.RowIndex].Cells)
                {
                    if ((cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())) && cell.ColumnIndex != 0)
                    {
                        return;
                    }

                    if (cell.ColumnIndex != 0)
                    {
                        columnsNames.Add(GetClientColumnName(clientsTable.Columns[cell.ColumnIndex].HeaderText));
                        newData.Add(cell.Value.ToString());
                    }
                }

                sql = $"INSERT INTO Client ({string.Join(", ", columnsNames)})" +
                $" VALUES ('{string.Join("', '", newData)}')";

                MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

                SQLManager.ExecuteSQLCommand(sql);

                UpdateClientTable();

                return;
            }

            sql = $"UPDATE Client SET {GetClientColumnName(clientsTable.Columns[e.ColumnIndex].HeaderText)} = '{clientsTable[e.ColumnIndex, e.RowIndex].Value}' WHERE CODE_CL = {clientsTable[0, e.RowIndex].Value};";

            MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

            SQLManager.ExecuteSQLCommand(sql);

            UpdateClientTable();
        }

        private string GetClientColumnName(string name)
        {
            string header = "";

            switch (name)
            {
                case "Имя":
                    header = "IMYA_CL";
                    break;
                case "Фамилия":
                    header = "FAM_CL";
                    break;
                case "Отчество":
                    header = "OTCH_CL";
                    break;
                case "Телефон":
                    header = "TELEFON_CL";
                    break;
                case "Номер паспорта":
                    header = "NOMER_PASP_CL";
                    break;
            }

            return header;
        }

        private void addClientToolButton_Click(object sender, EventArgs e)
        {
            clientsTable.Rows.Add();
        }

        private void deleteClientToolButton_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Client WHERE CODE_CL = {clientsTable[0, clientsTable.SelectedCells[0].RowIndex].Value}";

            MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

            SQLManager.ExecuteSQLCommand(sql);

            UpdateClientTable();
        }

        private void UpdateOrgsTable()
        {
            orgsTable.Rows.Clear();

            DataTable dataTable = SQLManager.GetDataTable("Organizatsia");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];

                orgsTable.Rows.Add();

                orgsTable.Rows[i].Cells[0].Value = row["CODE_ORG"];
                orgsTable.Rows[i].Cells[1].Value = row["NAME_ORG"];
                orgsTable.Rows[i].Cells[2].Value = row["ADRESS_ORG"];
                orgsTable.Rows[i].Cells[3].Value = row["RUKOVOD"];
                orgsTable.Rows[i].Cells[4].Value = row["TELEFON_ORG"];
            }
        }

        private void orgsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string sql;

            if (orgsTable[0, e.RowIndex].Value == null || string.IsNullOrWhiteSpace(orgsTable[0, e.RowIndex].Value.ToString()))
            {
                List<string> columnsNames = new List<string>();
                List<string> newData = new List<string>();

                foreach (DataGridViewCell cell in orgsTable.Rows[e.RowIndex].Cells)
                {
                    if ((cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())) && cell.ColumnIndex != 0)
                    {
                        return;
                    }

                    if (cell.ColumnIndex != 0)
                    {
                        columnsNames.Add(GetOrgColumnName(orgsTable.Columns[cell.ColumnIndex].HeaderText));
                        newData.Add(cell.Value.ToString());
                    }
                }

                sql = $"INSERT INTO Organizatsia ({string.Join(", ", columnsNames)})" +
                $" VALUES ('{string.Join("', '", newData)}')";

                MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

                SQLManager.ExecuteSQLCommand(sql);

                UpdateOrgsTable();

                return;
            }

            sql = $"UPDATE Organizatsia SET {GetOrgColumnName(orgsTable.Columns[e.ColumnIndex].HeaderText)} = '{orgsTable[e.ColumnIndex, e.RowIndex].Value}' WHERE CODE_ORG = {orgsTable[0, e.RowIndex].Value};";

            MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

            SQLManager.ExecuteSQLCommand(sql);

            UpdateOrgsTable();
        }

        private string GetOrgColumnName(string name)
        {
            string header = "";

            switch (name)
            {
                case "Название":
                    header = "NAME_ORG";
                    break;
                case "Адрес":
                    header = "ADRESS_ORG";
                    break;
                case "Руководитель":
                    header = "RUKOVOD";
                    break;
                case "Телефон":
                    header = "TELEFON_ORG";
                    break;
            }

            return header;
        }

        private void addOrgToolButton_Click(object sender, EventArgs e)
        {
            orgsTable.Rows.Add();
        }

        private void deleteOrgToolButton_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Organizatsia WHERE CODE_ORG = {orgsTable[0, orgsTable.SelectedCells[0].RowIndex].Value}";

            MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

            SQLManager.ExecuteSQLCommand(sql);

            UpdateOrgsTable();
        }

        private void UpdatePrepodsTable()
        {
            prepodsTable.Rows.Clear();

            DataTable dataTable = SQLManager.GetDataTable("Prepodavateli");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];

                prepodsTable.Rows.Add();

                prepodsTable.Rows[i].Cells[0].Value = row["CODE_PD"];
                prepodsTable.Rows[i].Cells[1].Value = row["IMYA_PD"];
                prepodsTable.Rows[i].Cells[2].Value = row["FAM_PD"];
                prepodsTable.Rows[i].Cells[3].Value = row["OTCH_PD"];
                prepodsTable.Rows[i].Cells[4].Value = row["STASH"];
                prepodsTable.Rows[i].Cells[5].Value = row["TELEFON_PD"];
                prepodsTable.Rows[i].Cells[6].Value = row["NOMER_PASP_PD"];
            }
        }

        private void prepodsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string sql;

            if (prepodsTable[0, e.RowIndex].Value == null || string.IsNullOrWhiteSpace(prepodsTable[0, e.RowIndex].Value.ToString()))
            {
                List<string> columnsNames = new List<string>();
                List<string> newData = new List<string>();

                foreach (DataGridViewCell cell in prepodsTable.Rows[e.RowIndex].Cells)
                {
                    if ((cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())) && cell.ColumnIndex != 0)
                    {
                        return;
                    }

                    if (cell.ColumnIndex != 0)
                    {
                        columnsNames.Add(GetPrepodColumnName(prepodsTable.Columns[cell.ColumnIndex].HeaderText));
                        newData.Add(cell.Value.ToString());
                    }
                }

                sql = $"INSERT INTO Prepodavateli ({string.Join(", ", columnsNames)})" +
                $" VALUES ('{string.Join("', '", newData)}')";

                MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

                SQLManager.ExecuteSQLCommand(sql);

                UpdatePrepodsTable();

                return;
            }

            sql = $"UPDATE Prepodavateli SET {GetPrepodColumnName(prepodsTable.Columns[e.ColumnIndex].HeaderText)} = '{prepodsTable[e.ColumnIndex, e.RowIndex].Value}' WHERE CODE_PD = {prepodsTable[0, e.RowIndex].Value};";

            MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

            SQLManager.ExecuteSQLCommand(sql);

            UpdatePrepodsTable();
        }

        private string GetPrepodColumnName(string name)
        {
            string header = "";

            switch (name)
            {
                case "Имя":
                    header = "IMYA_PD";
                    break;
                case "Фамилия":
                    header = "FAM_PD";
                    break;
                case "Отчество":
                    header = "OTCH_PD";
                    break;
                case "Стаж":
                    header = "STASH";
                    break;
                case "Телефон":
                    header = "TELEFON_PD";
                    break;
                case "Номер паспорта":
                    header = "NOMER_PASP_PD";
                    break;
            }

            return header;
        }

        private void addPrepodToolButton_Click(object sender, EventArgs e)
        {
            prepodsTable.Rows.Add();
        }

        private void deletePrepodToolButton_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Prepodavateli WHERE CODE_PD = {prepodsTable[0, prepodsTable.SelectedCells[0].RowIndex].Value}";

            MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

            SQLManager.ExecuteSQLCommand(sql);

            UpdatePrepodsTable();
        }

        private void UpdateKursTable()
        {
            kurssTable.Rows.Clear();

            DataTable dataTable = SQLManager.GetDataTable("Kurs");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string sql;

                DataRow row = dataTable.Rows[i];

                sql = $"SELECT NAME_ORG from Organizatsia WHERE CODE_ORG = {row["CODE_ORG"]}";
                string orgName = SQLManager.GetStringValue(sql, 0);

                sql = $"SELECT FAM_PD, IMYA_PD, OTCH_PD from Prepodavateli WHERE CODE_PD = {row["CODE_PD"]}";
                string prepodFam = SQLManager.GetStringValue(sql, 0);
                string prepodName = SQLManager.GetStringValue(sql, 1);
                string prepodOtch = SQLManager.GetStringValue(sql, 2);

                kurssTable.Rows.Add();

                kurssTable.Rows[i].Cells[0].Value = row["CODE_CY"];
                kurssTable.Rows[i].Cells[1].Value = $"Курс {row["NAME_KURS"]}";
                kurssTable.Rows[i].Cells[2].Value = $"{prepodFam} {prepodName} {prepodOtch}";
                kurssTable.Rows[i].Cells[3].Value = orgName;
                kurssTable.Rows[i].Cells[4].Value = row["CHASOV"];
                kurssTable.Rows[i].Cells[5].Value = row["PRICE"];
            }
        }

        private void deleteKursToolButton_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Kurs WHERE CODE_CY = {kurssTable[0, kurssTable.SelectedCells[0].RowIndex].Value}";

            MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

            SQLManager.ExecuteSQLCommand(sql);

            UpdateKursTable();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateClientTable();
            UpdateKursTable();
            UpdateOrgsTable();
            UpdatePrepodsTable();
            UpdateHistotyTable();
            UpdateDogovorTable();
        }

        private void addKursToolButton_Click(object sender, EventArgs e)
        {
            KursForm kursForm = new KursForm();
            kursForm.ShowDialog();

            UpdateKursTable();
        }

        private void editKursToolButton_Click(object sender, EventArgs e)
        {
            int kursId = (int)kurssTable[0, kurssTable.SelectedCells[0].RowIndex].Value;

            KursForm kursForm = new KursForm(kursId);
            kursForm.ShowDialog();

            UpdateKursTable();
        }

        private void UpdateHistotyTable()
        {
            historyTable.Rows.Clear();

            DataTable dataTable = SQLManager.GetDataTable("history");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];

                historyTable.Rows.Add();

                historyTable.Rows[i].Cells[0].Value = row["CODE_HIS"];
                historyTable.Rows[i].Cells[1].Value = row["CODE_DL"];
                historyTable.Rows[i].Cells[2].Value = row["Operation"];
                historyTable.Rows[i].Cells[3].Value = row["FamCL"];
                historyTable.Rows[i].Cells[4].Value = row["NameKurs"];
                historyTable.Rows[i].Cells[5].Value = row["delete_date"];
            }
        }

        private void UpdateDogovorTable()
        {
            dogovorTable.Rows.Clear();

            DataTable dataTable = SQLManager.GetDataTable("Dogovor");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];

                string sql = $"SELECT NAME_ORG from Organizatsia WHERE CODE_ORG = {row["CODE_ORG"]}";
                string orgName = SQLManager.GetStringValue(sql, 0);

                sql = $"SELECT FAM_CL, IMYA_CL, OTCH_CL from Client WHERE CODE_CL = {row["CODE_CL"]}";
                string clientFam = SQLManager.GetStringValue(sql, 0);
                string clientName = SQLManager.GetStringValue(sql, 1);
                string clientOtch = SQLManager.GetStringValue(sql, 2);

                sql = $"SELECT NAME_KURS from Kurs WHERE CODE_CY = {row["CODE_CY"]}";
                string kursName = SQLManager.GetStringValue(sql, 0);

                dogovorTable.Rows.Add();

                dogovorTable.Rows[i].Cells[0].Value = row["CODE_DOG"];
                dogovorTable.Rows[i].Cells[1].Value = orgName;
                dogovorTable.Rows[i].Cells[2].Value = $"{clientFam} {clientName} {clientOtch}";
                dogovorTable.Rows[i].Cells[3].Value = kursName;
                dogovorTable.Rows[i].Cells[4].Value = row["DATA"];
            }
        }

        private void deleteDogovorToolButton_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Dogovor WHERE CODE_DOG = {dogovorTable[0, dogovorTable.SelectedCells[0].RowIndex].Value}";

            MessageBox.Show(sql, "SQL Command", MessageBoxButtons.OK);

            SQLManager.ExecuteSQLCommand(sql);

            UpdateDogovorTable();
        }

        private void editDogovorToolButton_Click(object sender, EventArgs e)
        {
            int kursId = (int)dogovorTable[0, dogovorTable.SelectedCells[0].RowIndex].Value;

            EditDogovorForm dogovorForm = new EditDogovorForm(kursId);
            dogovorForm.ShowDialog();

            UpdateDogovorTable();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}