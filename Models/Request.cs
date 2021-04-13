using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GSAPP.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        [Required(ErrorMessage = "List what you need")]
        public string Items { get; set; }
        // user can write down everything they need in textbox
        [Required(ErrorMessage = "Please enter a date and time")]
        public DateTime Urgency { get; set; }
        public string Notes { get; set; }
        public bool IsCompleted { get; set; }
        // default val = false;
        public int PickedUpByID { get; set; }
        // user picking up task/ getting id instead of name to connect to db
        public DateTime CreatedAt = DateTime.Now;
        public DateTime UpdatedAt = DateTime.Now;
        public int UserID { get; set; }
        public User Creator { get; set; }
    }
}