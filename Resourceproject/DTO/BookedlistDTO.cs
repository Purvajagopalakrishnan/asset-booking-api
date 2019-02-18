using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resourceproject.DTO
{
    public class BookedlistDTO
    {
        public System.DateTime Startdate { get; set; }
        public System.DateTime Enddate { get; set; }
        public int Resource_Id { get; set; }
        public string Email { get; set; }
    }
}