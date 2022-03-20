using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Laundry_Prov_2.Models;

namespace LKS_Laundry_Prov_2.Controllers
{
    public class CheckOutController : ApiController
    {
        SqlConnection connection = new SqlConnection(Utils.conn);
        SqlCommand command;
        SqlDataReader reader;
        int idTrans;

        public string[] post(PostModel p)
        {
            command = new SqlCommand("insert into header_transaction values(" + p.id + ", " + p.customer + ", getdate(), null)", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            command = new SqlCommand("select top(1) id_header_transaction from header_transaction order by id_header_transaction desc", connection);
            connection.Open();
            reader = command.ExecuteReader();
            reader.Read();
            idTrans = reader.GetInt32(0);
            connection.Close();

            command = new SqlCommand("insert into detail_transaction values(null, " + idTrans + ", " + p.idPackage + ", " + p.price + ", " + p.totalUnit + ", null", connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return new string[] { "Success" };
            }
            catch (Exception ex)
            {
                return new string[] { ex.Message };
            }
        }
    }
}
