using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace GSAPP.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name required")]
        [MinLength(2, ErrorMessage = "Name should be more than 2 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [MinLength(2, ErrorMessage = "Last name should be more than 2 characters")]
        public string LastName { get; set; }

        [Required]
        public bool Status { get; set; }
        // upon registering you can choose Helper or Person in need of help??
        // true = needs help , false = helper
        [Required(ErrorMessage = "Venmo ID required")]
        public string VenmoId { get; set; }

        // public string ImageUrl { get; set; }

        // [NotMapped]
        // [Required(ErrorMessage = "Picture required")]
        // public IFormFile Photo { get; set; }

        [Required(ErrorMessage = "Phone # required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email required")]
        [EmailAddress]
        [MinLength(4, ErrorMessage = "Email address should be more than 4 characters")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirm password")]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

        // [Required(ErrorMessage = "Address required")]
        // [MinLength(5, ErrorMessage = "Name should be more than 5 characters")]
        // public string Address1 { get; set; }

        // public string Address2 { get; set; }

        // [Required(ErrorMessage = "City required")]
        // [MinLength(2, ErrorMessage = "Name should be more than 2 characters")]
        // public string City { get; set; }

        [Required(ErrorMessage = "Zip code required")]
        public int ZipCode { get; set; }

        // [Required(ErrorMessage = "Country required")]
        // public string Country { get; set; }

        // [Required(ErrorMessage = "State required")]
        // public string State { get; set; }

        public DateTime CreatedAt = DateTime.Now;
        public DateTime UpdatedAt = DateTime.Now;
        public List<Request> RequestsCreated { get; set; }
        // one to many ralationship to task model..
    }
}
[NotMapped]
public class Login
{
    [Required(ErrorMessage = "Enter your email")]
    [EmailAddress]
    public string LoginEmail { get; set; }

    [Required(ErrorMessage = "Enter your password")]
    [DataType(DataType.Password)]
    public string LoginPassword { get; set; }
}
