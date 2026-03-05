using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bmis.Classes
{
    public class DatabaseHelper
    {
        private string host = "localhost";
        private string database = "barangay";
        private string user = "root";
        private string password = "";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection($"server={host};database={database};user={user};password={password};port=3306;Convert Zero Datetime=True");
        }

        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Query Error: " + ex.Message); }
            return dt;
        }

        public bool ExecuteNonQuery(string sql, MySqlParameter[] parameters)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
                return false;
            }
        }
    }
}