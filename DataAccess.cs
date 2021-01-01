using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using System.Data;

namespace DataEXE
{
    public class DataAccess
    {
        public List<Item> GetData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DataEXE.Properties.Settings.DataConnectionString")))
            {
                return connection.Query<Item>($"select * from DpTable").ToList();
            }
        }
        public void AddData(string word)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DataEXE.Properties.Settings.DataConnectionString")))
            {
                List<Item> items = new List<Item>();

                items.Add(new Item { words = word });
                connection.Execute("AddTo @words", items);
            }
        }
        public void RemoveTo(int Id)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DataEXE.Properties.Settings.DataConnectionString")))
            {
                List<Item> items = new List<Item>();
                items.Add(new Item { Id = Id });
                connection.Execute("RemoveTo @Id", items);
            }
        }

    }
}
