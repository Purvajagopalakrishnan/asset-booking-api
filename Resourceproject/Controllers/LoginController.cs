using Resourceproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Resourceproject.Controllers
{
    [Route("api/login")]
    public class LoginController : ApiController
    {
        [HttpPost]
        public bool GetUserdetails(User user)
        {
            var entities = new LoginDBEntities();
            var result = entities.Users.Where(x => x.Email == user.Email && x.Password == user.Password).Any();
            return result;
        }
        public HttpResponseMessage Options()
        {
            var response = new HttpResponseMessage();
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
    }
}
