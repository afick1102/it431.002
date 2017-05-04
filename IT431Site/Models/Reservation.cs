using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT431Site.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        [StringLength(30)]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Customer Phone")]
        [DataType(DataType.PhoneNumber)]
        public string CustomerPhone { get; set; }

        [Required]
        [Display(Name = "Customer Email")]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }

        [Required]
        [Display(Name = "Location")]
        public int? LocationID { get; set; }

        public virtual Location Location { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<System.DateTime> StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<System.DateTime> EndDate { get; set; }

        [Required]
        [Display(Name = "Travel Reason")]
        public string TravelReason { get; set; }

        [Required]
        [Display(Name = "Number of Adult")]
        public AdultList AdultNum { get; set; }

        [Required]
        [Display(Name = "Number of Children")]
        public ChildrenList ChildrenNum { get; set; }

    }
}