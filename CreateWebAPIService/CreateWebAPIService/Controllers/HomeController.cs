using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CreateWebAPIService.Controllers
{
    public class HomeController : ApiController
    {
        public IEnumerable<employeesData> Get()
        {
            using ()
        }

        //[HttpPost]
        //public bool AddEmpDetails()
        //{
        //    return true;
        //}

        //[HttpGet]
        //public string GetEmpDetails()
        //{
        //    return "Test Employee";
        //}


    }
}
