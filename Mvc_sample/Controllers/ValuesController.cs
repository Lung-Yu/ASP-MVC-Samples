using Mvc_sample.Models;
using System;
using System.Collections;
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
            List<Models.Product> result = new List<Models.Product>();

            Models.DB_testEntities db = new Models.DB_testEntities();
            result = (from s in db.Products select s).ToList();

            return result;
        }

        // GET api/values/5
        public IEnumerable<ProductWithImage> Get(int id)
        {

            List<ProductWithImage> result = new List<ProductWithImage>();

            Models.DB_testEntities db = new Models.DB_testEntities();

            result = (from p in db.Products
                      join b in db.Images on p.DefaultImageId equals b.id
                      select new ProductWithImage { Name = p.Name, Price = p.Price, Path = b.path }).ToList();

           return result;
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