using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssistantWeb.Models.Users
{
    public class UserLogin
    {
        [Required]
        [Display(Name = "Email address")]
        [RegularExpression(@"[A-Za-z_][A-Za-z0-9_\.]{2,}@[A-Za-z]+(\.[A-Za-z]{2,})+", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [RegularExpression(@"[A-Za-z0-9\-_@#\$]{4,}", ErrorMessage = "Invalid password format.")]
        public string Password { get; set; }
    }
}