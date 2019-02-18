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
    public class CheckAvailabilityController : ApiController
    {
        [HttpPost]
        public bool SetAvailabilityStatus([FromBody]BookedlistDTO bookedlist)
        {
            var entities = new LoginDBEntities();
            var result = entities.Bookedlists.Where(x => (x.Startdate >= bookedlist.Startdate && x.Startdate < bookedlist.Enddate) || (x.Startdate <= bookedlist.Startdate && x.Enddate > bookedlist.Enddate) ||
            (x.Enddate > bookedlist.Startdate && x.Enddate <= bookedlist.Enddate) && (x.Resource_Id == bookedlist.Resource_Id)).Any();
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
