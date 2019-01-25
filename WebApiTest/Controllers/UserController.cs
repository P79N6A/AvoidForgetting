using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class UserController : ApiController
    {
        List<User> users = new List<User> {
            new User {Id=1,Name="1",Age=1},
            new User {Id=2,Name="2",Age=2},
            new User {Id=3,Name="3",Age=3}
        };
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
