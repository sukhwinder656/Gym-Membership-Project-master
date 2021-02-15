using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GymMembership_Project.Models;

namespace GymMembership_Project.Data
{
    public class GymMembership_ProjectContext : DbContext
    {
        public GymMembership_ProjectContext(DbContextOptions<GymMembership_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<GymMembership_Project.Models.Trainer> Trainers { get; set; }
        public DbSet<GymMembership_Project.Models.Package> Packages { get; set; }
        public DbSet<GymMembership_Project.Models.Member> Members { get; set; }
    }
}
