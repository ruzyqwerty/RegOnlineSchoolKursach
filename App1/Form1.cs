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

            string sql;

            if (string.IsNullOrWhiteSpace(dataGridView1[0, e.RowIndex].Value.ToString()))
            {
                List<string> columnsNames = new List<string>();
                List<string> newData = new List<string>();

                foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
                {
                    if (string.IsNullOrWhiteSpace(cell.Value.ToString()) && cell.ColumnIndex != 0)
                    {
                        statusLabel.Text = "Null value in " + dataGridView1.Columns[cell.ColumnIndex].HeaderText;
                        return;
                    }

                    if (cell.ColumnIndex != 0)
                    {
                        columnsNames.Add(dataGridView1.Columns[cell.ColumnIndex].HeaderText);
                        newData.Add(cell.Value.ToString());
                    }
                }

                sql = $"INSERT INTO {currentDataTableName} ({string.Join(", ", columnsNames)})" +
                $" VALUES ('{string.Join("', '", newData)}')";

                ExecuteSQLCommand(sql);

                return;
            }

            sql = "UPDATE " + currentDataTableName + " SET " + dataGridView1.Columns[e.ColumnIndex].HeaderText +
                    " = '" + dataGridView1[e.ColumnIndex, e.RowIndex].Value + "' WHERE "
                    + dataGridView1.Columns[0].HeaderText + " = " + dataGridView1[0, e.RowIndex].Value + ";"; ;

            ExecuteSQLCommand(sql);
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

        private void TablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDataTableName = tablesList.SelectedItem.ToString();

            LoadCurrentTable();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            statusLabel.Text = dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value.ToString();

            string sql = "DELETE FROM " + currentDataTableName +
                " WHERE " + dataGridView1.Columns[0].HeaderText + "='" + dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value.ToString() + "';";

            ExecuteSQLCommand(sql);

            statusLabel.Text = sql;
        }

        private void ExecuteSQLCommand(string sql)
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

        private void AddRowToolboxButton_Click(object sender, EventArgs e)
        {
            currentDataTable.Rows.Add(currentDataTable.NewRow());


        }
    }
}
