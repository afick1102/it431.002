using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT431Site.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Date Open")]
        public DateTime DateOpen { get; set; }

        [Required]
        [Display(Name = "Date Closed")]
        public DateTime DateClosed { get; set; }

        [Required]
        [Display(Name = "Location Name")]
        [StringLength(30)]
        public string LocationName { get; set; }

        [Required]
        [Display(Name = "Location Description")]
        [StringLength(100)]
        public string LocationDescription { get; set; }

        [Required]
        [Display(Name = "Location Type")]
        public string LocationType { get; set; }

        [Required]
        [Display(Name = "Additional Benefits")]
        public string AddBenefit { get; set; }
    }
}