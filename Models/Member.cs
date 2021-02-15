using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymMembership_Project.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        [Required]
        public int PackageId { get; set; }
        public Package Package { get; set; }
    }
}
