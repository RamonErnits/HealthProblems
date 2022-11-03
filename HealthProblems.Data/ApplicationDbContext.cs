using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HealthProblems.Data;
using HealthProblems.core.Domain;

namespace HealthProblems.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> users { get; set; }
    }
}