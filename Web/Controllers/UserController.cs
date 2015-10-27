using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/Users/5
        [HttpGet]
        public List<object> GetUsers()
        {
            var users = new List<object>();

            users.Add(new { Name = "Jhon", Nacionality = "Brazil", Pictures = 15 });
            users.Add(new { Name = "Jack", Nacionality = "Australia", Pictures = 11 });
            users.Add(new { Name = "Kim", Nacionality = "United States", Pictures = 3 });

            return users;
        }
    }
}
