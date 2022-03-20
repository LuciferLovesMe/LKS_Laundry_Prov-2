using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Laundry_Prov_2.Models;

namespace LKS_Laundry_Prov_2.Controllers
{
    public class LoginController : ApiController
    {
        LKS_Laundry_ProvEntities row = new LKS_Laundry_ProvEntities();

        [HttpPost]
        public IHttpActionResult result (Utils u)
        {
            string q = "select * from employee where email_employee = '" + u.username + "' and password_Employee = '" + u.pass + "'";
            var user = row.Employees.SqlQuery(q).FirstOrDefault();
            if (user != null)
            {
                u.id = user.id;
                u.name = user.name_employee;
                u.phone = user.phone_number_employee;

                return Ok(u);
            }

            return null;
        }
    }
}
