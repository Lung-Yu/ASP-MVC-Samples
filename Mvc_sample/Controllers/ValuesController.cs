using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mvc_sample.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Models.Product> Get()
        {
            //return new string[] { "value1", "value2" };

            List<Models.Product> result = new List<Models.Product>();

            Models.DB_testEntities db = new Models.DB_testEntities();
            result = (from s in db.Products select s).ToList();
            return result;

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