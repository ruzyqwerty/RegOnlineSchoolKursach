using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace App1.SQL
{
    public class SQLManager
    {
        private readonly string connectionString;

        public SQLManager()
        {
            connectionString = "Server = localhost\\SQLEXPRESS; Database = RegOnlineSchool; Trusted_Connection = True;";
        }

        // получаем строку из SQL-запроса под номером columnIndex
        public virtual string GetStringValue(string sql, int columnIndex)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                string data = "";

                while (reader.Read())
                {
                    data = reader.GetString(columnIndex);
                }

                reader.Close();

                return data;
            }
        }

        // получаем время из SQL-запроса под номером columnIndex
        public virtual DateTime GetDataTimeValue(string sql, int columnIndex)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                DateTime data = DateTime.Now;

                while (reader.Read())
                {
                    data = reader.GetDateTime(columnIndex);
                }

                reader.Close();

                return data;
            }
        }

        // получаем деньги из SQL-запроса под номером columnIndex
        public virtual decimal GetMoneyValue(string sql, int columnIndex)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                decimal data = 1;

                while (reader.Read())
                {
                    data = reader.GetDecimal(columnIndex);
                }

                reader.Close();

                return data;
            }
        }

        // получаем целое число из SQL-запроса под номером columnIndex
        public virtual int GetIntValue(string sql, int columnIndex)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                int data = -1;

                while (reader.Read())
                {
                    data = reader.GetInt32(columnIndex);
                }

                reader.Close();

                return data;
            }
        }

        // получаем список ключей из SQL-запроса
        public virtual List<int> GetKeysValues(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                int data = -1;

                List<int> keys = new List<int>();

                while (reader.Read())
                {
                    data = reader.GetInt32(0);
                    keys.Add(data);
                }

                reader.Close();

                return keys;
            }
        }

        // получаем спислк строк из SQL-запроса
        public virtual List<string> GetStringValues(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                string data = "";

                List<string> keys = new List<string>();

                while (reader.Read())
                {
                    data = reader.GetString(0);

                    if (string.IsNullOrEmpty(data))
                        continue;

                    keys.Add(data);
                }

                reader.Close();

                return keys;
            }
        }

        // выполняем sql-запрос
        public object ExecuteSQLCommand(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    return command.ExecuteScalar();
                }
                catch (Exception) { }
            }

            return null;
        }

        // получаем целую таблицу по её названию
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
