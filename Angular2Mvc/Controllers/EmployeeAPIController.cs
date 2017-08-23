using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Angular2Mvc.DBContext;
using Newtonsoft.Json;
using System.Text;
using System.Data.Entity;

namespace Angular2Mvc.Controllers
{
    public class EmployeeAPIController : BaseAPIController
    {
        public HttpResponseMessage Get()
        {
            return ToJson(EmployeeDB.TblEmployees.AsEnumerable());
        }

        public HttpResponseMessage Post([FromBody]TblEmployee value)
        {
            EmployeeDB.TblEmployees.Add(value);
            return ToJson(EmployeeDB.SaveChanges());
        }

        public HttpResponseMessage Put(int id, [FromBody]TblEmployee value)
        {
            EmployeeDB.Entry(value).State = EntityState.Modified;
            return ToJson(EmployeeDB.SaveChanges());
        }
        public HttpResponseMessage Delete(int id)
        {
            EmployeeDB.TblEmployees.Remove(EmployeeDB.TblEmployees.FirstOrDefault(x => x.Id == id));
            return ToJson(EmployeeDB.SaveChanges());
        }
    }
}
