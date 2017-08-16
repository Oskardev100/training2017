using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProducts.WebAPI.Controllers
{
    public class ProductImagesController : ApiController
    {
        // GET: api/ProductImages
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProductImages/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductImages
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductImages/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProductImages/5
        public void Delete(int id)
        {
        }
    }
}
