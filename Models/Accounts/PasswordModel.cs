﻿using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Accounts
{
    public class PasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [StringLength(maximumLength: 100, ErrorMessage = "Password must be at least six characters long!", MinimumLength = 6)]
        //, ErrorMessage = "Password must be at least six characters long!")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and its confirmation do not match")]
        public string ConfirmPassword { get; set; }
    }
}
