using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT431Site.Models
{
    public class Location
    {
        public int Id { get; set; }
        public DateTime DateOpen { get; set; }

        public DateTime DateClosed { get; set; }

        public string LocationName { get; set; }

        public string LocationDescription { get; set; }

        public string LocationType { get; set; }

        public string AddBenefit { get; set; }
    }
}