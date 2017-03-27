using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CrossDeviceCommunicationAPI.Models;

namespace CrossDeviceCommunicationAPI.Controllers
{
    
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            string file = System.Web.HttpContext.Current.Server.MapPath("~/data/data.txt");
            string text = System.IO.File.ReadAllText(file);
            return new string[] {text };
        }

        // GET api/values/5
        public string Get(int id)
        {
            string file = System.Web.HttpContext.Current.Server.MapPath("~/data/data.txt");
            string text = System.IO.File.ReadAllText(file);
            return text;
        }

        // POST api/values
        [HttpPost]
        public void Post(TriggerValue v)
        {
            string file = System.Web.HttpContext.Current.Server.MapPath("~/data/data.txt");
            System.IO.File.WriteAllText(file, v.trigger);
        }
    }
}
