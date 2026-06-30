using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Contexts
{
    internal class InheritanceDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = DKH4_SWD5_S1.EFInheritance; Trusted_Connection = True; Encrypt = False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH
            //modelBuilder.Entity<FullTime>().HasBaseType<Person>();
            //modelBuilder.Entity<PartTime>().HasBaseType<Person>();
            //modelBuilder.Entity<Person>()
            //    .ToTable("Persons")
            //    .HasDiscriminator<string>("PersonType")
            //    .HasValue<FullTime>("FullTime")
            //    .HasValue<PartTime>("PartTime"); 
            #endregion
            #region TPT
            //modelBuilder.Entity<Person>().ToTable("Persons");
            //modelBuilder.Entity<FullTime>().ToTable("FullTime");
            //modelBuilder.Entity<PartTime>().ToTable("PartTime");
            #endregion

            #region TPC
            modelBuilder.Entity<FullTime>().UseTpcMappingStrategy();
            modelBuilder.Entity<PartTime>().UseTpcMappingStrategy();
            #endregion
        }

        #region TPH
        //public DbSet<FullTime> FullTimePerson { get; set; }
        //public DbSet<PartTime> PartTimePerson { get; set; }

        //public DbSet<Person> Persons { get; set; }
        #endregion

        #region TPT
        //public DbSet<Person> Persons { get; set; }
        //public DbSet<FullTime> FullTimePersons { get; set; }
        //public DbSet<PartTime> PartTimePersons { get; set; }
        #endregion

        #region TPC
        public DbSet<FullTime> FullTimePersons { get; set; }
        public DbSet<PartTime> PartTimePersons { get; set; }
        #endregion
    }
}
