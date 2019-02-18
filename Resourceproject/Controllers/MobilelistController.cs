using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Resourceproject.Models;

namespace Resourceproject.Controllers
{
    [Route("api/mobilelist")]
    public class MobilelistController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetMobilelist()
        {
            var entity = new LoginDBEntities();
            var listresult = entity.Mobilelists.ToList();
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
