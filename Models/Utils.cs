using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LKS_Laundry_Prov_2.Models
{
    public class Utils
    {
        public static string conn = @"Data Source=asmodeus;Initial Catalog=LKS_Laundry_Prov;Integrated Security=True";

        public string name { set; get; }
        public string phone { set; get; }
        public string username { set; get; }
        public string pass { set; get; }
        public int id { set; get; }

        public static DataTable getdata(SqlCommand command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }

    public class PostModel
    {
        public int id { set; get; }
        public int customer { set; get; }
        public int idPackage { set; get; }
        public int price { set; get; }
        public int totalUnit { set; get; }
    }
}