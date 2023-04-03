using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthMatch.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(5)]
        [MinLength(5)]
        public string Zipcode { get; set; }
        [Required]
        public string UrgencyNeed { get; set; }
       
        
    }
}
