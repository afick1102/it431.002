using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT431Site.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Date Open")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<System.DateTime> DateOpen { get; set; }

        [Required]
        [Display(Name = "Date Closed")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<System.DateTime> DateClosed { get; set; }

        [Required]
        [Display(Name = "Location Name")]
        [StringLength(50)]
        public string LocationName { get; set; }

        [Required]
        [Display(Name = "Location Description")]
        [StringLength(200)]
        public string LocationDescription { get; set; }

        [Required]
        [Display(Name = "Location Type")]
        public string LocationType { get; set; }

        [Required]
        [Display(Name ="Location Image")]
        public string LocationImg { get; set; }

        [Display(Name = "Free WiFi")]
        public bool BenefitsAdded { get; set; }

        [Display(Name = "Housekeeping")]
        public bool HousekeepingAdded { get; set; }

        [Display(Name = "24/7 Gym")]
        public bool GymAdded { get; set; }

        [Display(Name = "Continental Breakfast")]
        public bool BreakfastAdded { get; set; }
    }
}