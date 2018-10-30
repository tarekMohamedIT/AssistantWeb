using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssistantWeb.Models.Money
{
    public class Wallet
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Wallet's name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "The total amount of money in that wallet")]
        public float TotalMoney { get; set; }

        [Required]
        [Display(Name = "The total amount of money")]
        public float RemainingMoney { get; set; }
    }
}