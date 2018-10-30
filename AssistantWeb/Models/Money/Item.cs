using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssistantWeb.Models.Money
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [Range(3, 20)]
        public string Name { get; set; }

        [Required]
        public float quantity { get; set; }

        [Required]
        public float PricePerUnit { get; set; }
        public DateTime? DateAdded { get; set; }

        public Wallet Wallet { get; set; }

        [Required]
        public int WalletId { get; set; }
    }
}