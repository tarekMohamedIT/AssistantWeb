using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssistantWeb.Models.Pricing
{
    public class Plan
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Plan")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Price per year")]
        public float PriceAnnual { get; set; }

        [Required]
        [Display(Name = "Access to the 3 cores")]
        public bool UseAll { get; set; }

        [Required]
        [Display(Name = "Access to the main core")]
        public bool UseCore { get; set; }

        [Required]
        [Display(Name = "Smart support")]
        public bool ProvideSupport { get; set; }
    }
}