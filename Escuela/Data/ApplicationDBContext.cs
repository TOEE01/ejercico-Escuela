using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escuela.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Escuela.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options)
            : base(options)
        {
            
        }

        public DbSet<Student> students { get; set; }

        public DbSet<Enrollment> enrollments { get; set; }

        public DbSet<Course> courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
