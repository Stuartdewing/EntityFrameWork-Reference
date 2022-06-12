using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DataAccess
{
    public class NameContext : DbContext // Inherit Microsoft.EntityFramework.Core
    {
    // Constructor that calls the base constructor with those options that have been pasted in.
        public NameContext(DbContextOptions options) : base(options) { }    // Constructor
    // Sets up the tables for the database
        public DbSet<Model1Address> Addresses { get; set; }                 // Property
        public DbSet<Model2Email> EmailAddresses { get; set; }              // Property
        public DbSet<Model3Person> People { get; set; }                     // Property
    }
}
