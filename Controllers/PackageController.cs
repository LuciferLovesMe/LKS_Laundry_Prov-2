﻿using System;
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
    public class PackageController : ApiController
    {
        SqlConnection connection = new SqlConnection(Utils.conn);
        SqlCommand command;

        public DataTable getdata()
        {
            command = new SqlCommand("select * from package", connection);
            return Utils.getdata(command);
        }
    }
}
