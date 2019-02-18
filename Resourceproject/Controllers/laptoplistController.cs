using Resourceproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Resourceproject.Controllers
{
    public class laptoplistController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetLaptoplist()
        {
            var entity = new LoginDBEntities();
            var listresult = entity.Laptoplists.ToList();
            return Ok(listresult);
        }
        public HttpResponseMessage Options()
        {
            var response = new HttpResponseMessage();
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
    }
}
