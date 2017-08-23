using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Angular2Mvc.DBContext;
using Newtonsoft.Json;
using System.Text;

namespace Angular2Mvc.Controllers
{
    public class BaseAPIController : ApiController
    {

        protected readonly EmployeeTstEntities EmployeeDB = new EmployeeTstEntities();
        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
