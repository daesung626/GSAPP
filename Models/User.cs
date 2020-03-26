using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GSAPP.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Enter a name")]
        [MinLength(2, ErrorMessage = "Name should be more than 2 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter a last name")]
        [MinLength(2, ErrorMessage = "Last name should be more than 2 characters")]
        public string LastName { get; set; }

        [Required]
        public string Status { get; set; }
        // upon registering you can choose Helper or Person in need of help??

        [Required]
        [EmailAddress]
        [MinLength(4, ErrorMessage = "Email address should be more than 4 characters")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; }

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }

        public virtual Address Location { get; set; }
        // joining one to one to adress 
        // see  adress model
        public DateTime CreatedAt = DateTime.Now;
        public DateTime UpdatedAt = DateTime.Now;
        public List<Task> TasksCreated { get; set; }
        // one to many ralationship to task model..
    }
    [NotMapped]
    public class Login
    {
        [Required]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}

// Hello world!! - Rolando
// juan was here
// new change to see if it works for daesung