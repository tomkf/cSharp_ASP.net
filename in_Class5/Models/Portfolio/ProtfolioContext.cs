using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace in_Class5.Models.Portfolio
{
    public class ProtfolioContext : DbContext 
    {
        // my constructor  //the portfolio context is a GENERIC TYPE 
        public ProtfolioContext(DbContextOptions<ProtfolioContext> options) : base (options) { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Technology> Technologies { get; set; }

        public DbSet<TechnologyProjects> TechnologyProjects { get; set; }

        // override of parent DbContext's virtual method.
        //thios to define foreing keys on a bridge table
        //in entity, foreign keys are somewhat unnessesary 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define bridge table's composite primary key.

            modelBuilder.Entity<TechnologyProjects>()
                .HasKey(tp => new { tp.TechnoglyName, tp.ProjectId });

            // Define bridge table's foreign keys.
            modelBuilder.Entity<TechnologyProjects>()
              .HasOne(tp => tp.Technology)
              .WithMany(tp => tp.TechnologyProjects)
              .HasForeignKey(fk => new { fk.TechnoglyName })
              .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete CHILD CAN not DELETE IT'S PARENT
            

            //one with many relationship, one project can be part of many techjnology projects
            modelBuilder.Entity<TechnologyProjects>()
              .HasOne(tp => tp.Project)
              .WithMany(tp => tp.TechnologyProjects)
              .HasForeignKey(fk => new { fk.ProjectId })
              .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete
        }
    }
}
