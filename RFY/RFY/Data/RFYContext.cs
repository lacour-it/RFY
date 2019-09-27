using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RFY.Models;

namespace RFY.Data
{
    public class RFYContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public RFYContext(DbContextOptions<RFYContext> options) : base(options)
        {
        }

        public DbSet<NetworkInterface> NetworkInterfaces { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
