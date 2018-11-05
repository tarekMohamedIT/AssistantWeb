using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssistantWeb.Models.Users
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First name")]
        [RegularExpression("[A-Z][A-Za-z]{2,}", ErrorMessage = "Invalid first name format.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        [RegularExpression("[A-Z][A-Za-z]{2,}", ErrorMessage = "Invalid last name format.")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email address")]
        [RegularExpression(@"[A-Za-z_][A-Za-z0-9_\.]{2,}@[A-Za-z]+(\.[A-Za-z]{2,})+", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [RegularExpression(@"[A-Za-z0-9\-_@#\$]{4,}", ErrorMessage = "Invalid password format.")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [RegularExpression(@"[0-9+]+", ErrorMessage = "Invalid phone number format.")]
        public string PhoneNumber { get; set; }
    }
}