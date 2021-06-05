using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace App1.SQL
{
    public class SQLManager
    {
        private readonly string connectionString;
        public SQLManager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public virtual string GetStringValue(string sql, int columnIndex)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                string data = "";

                while(reader.Read())
                {
                    data = reader.GetString(columnIndex);
                }

                reader.Close();

                return data;
            }
        }

        public virtual void ExecuteSQLCommand(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                command.ExecuteNonQuery();

                //connection.Close();
            }
        }

        public virtual DataTable GetDataTable(string tableName)
        {
            string sql = "SELECT * FROM " + tableName;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataSet DataSet = new DataSet();

                adapter.Fill(DataSet);

                return DataSet.Tables[0];
            }
        }
    }
}
