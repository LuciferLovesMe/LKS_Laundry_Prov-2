using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Laundry_Prov_2.Models;

namespace LKS_Laundry_Prov_2.Controllers
{
    public class CustomerController : ApiController
    {
        SqlConnection connection = new SqlConnection(Utils.conn);
        SqlCommand command;

        [HttpPost]
        public DataTable getdata(Utils u)
        {
            command = new SqlCommand("select top(1) * from customer where phone_number_customer like '%" + u.phone + "%'", connection);
            return Utils.getdata(command);
        }
    }
}
