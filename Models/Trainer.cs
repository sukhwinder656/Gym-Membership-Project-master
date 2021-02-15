using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymMembership_Project.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(18, int.MaxValue, ErrorMessage = "Age should be greater than or equal to 18")]
        public int Age { get; set; }
        [Display(Name="Contact")]
        public string Contact_Number { get; set; }
    }
}
