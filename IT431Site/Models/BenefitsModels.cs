using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT431Site.Models
{
    public class BenefitsModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BenId { get; set; }
        public IList<string> SelectedBenefits { get; set; }

        public IList<SelectListItem> AvailableBenefits { get; set; }

        public BenefitsModels()
        {
            SelectedBenefits = new List<string>();
            AvailableBenefits = new List<SelectListItem>();
        }
    }
}