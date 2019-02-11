using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Resourceproject.Models;

namespace Resourceproject.Controllers
{
    [RoutePrefix("api/resourcedetails")]
    public class ResourcedetailsController : ApiController
    {
        [HttpGet]
        [ActionName("GetMobilelist")]
        public IHttpActionResult GetMobilelist()
        {
            var entity = new LoginDBEntities();
            var listresult = entity.Mobilelists.ToList();
            return Ok(listresult);
        }
        [HttpGet]
        [ActionName("GetLaptoplist")]
        public IHttpActionResult GetLaptoplist()
        {
            var entity = new LoginDBEntities();
            var listresult = entity.Laptoplists.ToList();
            return Ok(listresult);
        }
    }
}
