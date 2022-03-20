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
    public class NotifController : ApiController
    {
        SqlConnection connection = new SqlConnection(Utils.conn);
        SqlCommand command;

        [HttpPost]
        public DataTable data(Utils u)
        {
            command = new SqlCommand("select * from header_transaction join package on package.id_package = header_transaction.id_package join employee on employee.id = header_transaction.id_employee where header_Transaction.id_employee = " + u.id, connection);
            return Utils.getdata(command);
        }
    }
}
