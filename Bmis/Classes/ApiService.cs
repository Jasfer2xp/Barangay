using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;

namespace Bmis.Classes
{
    public class ApiService
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "http://58.69.118.16:83/api/";
        private const string ApiKey = "1q2w3e4r5t";

        public async Task<DataTable> GetResidentDataSmart(int id)
        {
            DataTable dt = await GetEmployeeData($"employee-details/{id}");

            if (dt == null || dt.Rows.Count == 0)
            {
                DatabaseHelper localDb = new DatabaseHelper();
                string sql = "SELECT id, full_name, age, purok, resident_image FROM residents WHERE id = @id";
                MySqlParameter[] param = {
                    new MySqlParameter("@id", id)
                };
                return localDb.ExecuteQuery(sql, param);
            }

            return dt;
        }

        public async Task<DataTable> GetEmployeeData(string endpoint)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-API-KEY", ApiKey);
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(BaseUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonToDataTable(json);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Connection Error: " + ex.Message);
            }
            return null;
        }

        private DataTable JsonToDataTable(string json)
        {
            DataTable dt = new DataTable("ResidentTable");
            dt.Columns.Add("id");
            dt.Columns.Add("full_name");
            dt.Columns.Add("age");
            dt.Columns.Add("purok");
            dt.Columns.Add("resident_image", typeof(byte[]));

            JObject obj = JObject.Parse(json);
            var dataToken = obj["data"];

            if (dataToken is JArray array)
            {
                foreach (var item in array)
                {
                    if (item["userDetails"] != null) AddRow(dt, item["userDetails"]);
                }
            }
            else if (dataToken != null && dataToken["userDetails"] != null)
            {
                AddRow(dt, dataToken["userDetails"]);
            }

            return dt;
        }

        private void AddRow(DataTable dt, JToken user)
        {
            dt.Rows.Add(
                user["hrId"]?.ToString(),
                user["fullname"]?.ToString(),
                0,
                "N/A",
                null
            );
        }
    }
}