using System;
using System.ComponentModel.DataAnnotations;

namespace GSAPP.Models
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }

        [Required]
        public string Category { get; set; }
        // 1.groceries
        // 2.medication
        // 3.other
        [Required]
        public string Items { get; set; }
        // user can write down everything they need in textbox

        [Required]
        public string Urgency { get; set; }
        // 1. low
        // 2. normal
        // 3. critical
        [Required]
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