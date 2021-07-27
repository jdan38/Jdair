using Jdair.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jdair.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Category> Category { get; set; }
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<Makemodel> Makemodel { get; set; }
        public DbSet<Flight> Flight{ get; set; }
        public DbSet<Airports> Airports { get; set; }
    }
}
