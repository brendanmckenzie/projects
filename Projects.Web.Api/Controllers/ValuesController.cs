using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace Projects.Web.Api.Controllers
{
    public class AccessController : ApiController
    {
        // GET /api/values
        public IEnumerable<object> Get()
        {
            return new object[] { DateTime.Now, "value2" };
        }

        // POST /api/values
        public void Post(string value)
        {
        }

        // PUT /api/values/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/values/5
        public void Delete(int id)
        {
        }
    }
}