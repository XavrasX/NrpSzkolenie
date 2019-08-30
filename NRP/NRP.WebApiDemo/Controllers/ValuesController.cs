using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NRP.WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        public IEnumerable<dynamic> Get()
        {
            return new dynamic[] { new { FirstName = "Dariusz", LastName="Popis", BirthDate=DateTime.Now.AddYears(-47)},
                new { FirstName = "Kinga", LastName = "Gawrysiak" }
            };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
