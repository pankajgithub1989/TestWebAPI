using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestAPI.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public string GetName()
        {
            return "Pankaj";
        }
        [HttpGet]
        public string GetName(string name)
        {
            return name;
        }
    }
}
