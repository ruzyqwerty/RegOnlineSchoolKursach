using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using App1.Enums;

namespace App1
{
    public partial class Form1 : Form
    {
        private DataSet currentDataSet;

        private DataTable currentDataTable;

        private string currentDataTableName = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablesList.Items.AddRange(new object[5] { Tables.Client.Value, Tables.Dogovor.Value, Tables.Kurs.Value,
                                                        Tables.Organizatsia.Value , Tables.Prepodavateli.Value });

            tablesList.SelectedItem = Tables.Client.Value;

            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                statusLabel.Text = "Can't change primary key";
                dataGridView1.DataSource = currentDataTable;
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string sql = "UPDATE " + currentDataTableName + " SET " + dataGridView1.Columns[e.ColumnIndex].HeaderText +
                    " = '" + dataGridView1[e.ColumnIndex, e.RowIndex].Value + "' WHERE "
                    + dataGridView1.Columns[0].HeaderText + " = " + dataGridView1[0, e.RowIndex].Value + ";"; ;

            executeSQLCommand(sql);
        }

        private void LoadCurrentTable()
        {
            if (currentDataTableName == null)
            {
                currentDataTableName = Tables.Client.Value;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string sql = "SELECT * FROM " + currentDataTableName;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                currentDataSet = new DataSet();

                adapter.Fill(currentDataSet);

                currentDataTable = currentDataSet.Tables[0];

                dataGridView1.DataSource = currentDataTable;

                statusLabel.Text = "Connect to " + currentDataTableName;
            }
        }

        private void UpdateDataGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string sql = "SELECT * FROM " + currentDataTableName;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                currentDataSet.Clear();

                adapter.Fill(currentDataSet);

                statusLabel.Text = currentDataTableName + " updated";
            }
        }

        private void tablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDataTableName = tablesList.SelectedItem.ToString();

            LoadCurrentTable();
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            statusLabel.Text = dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value.ToString();

            string sql = "DELETE FROM " + currentDataTableName +
                " WHERE " + dataGridView1.Columns[0].HeaderText + "='" + dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value.ToString() + "';";

            executeSQLCommand(sql);

            statusLabel.Text = sql;
        }

        private void executeSQLCommand(string sql)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                int modifedRowsNumber = command.ExecuteNonQuery();

                UpdateDataGridView();

                statusLabel.Text = sql;
            }
        }
    }
}
