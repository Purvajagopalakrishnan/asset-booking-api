using Resourceproject.DTO;
using Resourceproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Resourceproject.Controllers
{
    [Route("api/bookresource")]
    public class BookResourceController : ApiController
    {
        [HttpPost]
       
        public IHttpActionResult BookResource([FromBody]BookedlistDTO bookedlistDTO)
        {
            var entities = new LoginDBEntities();
            var bookedlist = new Bookedlist();
        
                bookedlist.Startdate = bookedlistDTO.Startdate;
                bookedlist.Enddate = bookedlistDTO.Enddate;
                bookedlist.Email = bookedlistDTO.Email;
                bookedlist.Resource_Id = bookedlistDTO.Resource_Id;
                entities.Bookedlists.Add(bookedlist);
                var result = entities.SaveChanges();
                return Ok(bookedlist);
        }
        public HttpResponseMessage Options()
        {
            var response = new HttpResponseMessage();
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
    }
}
