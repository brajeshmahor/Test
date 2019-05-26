using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BMS.Services.Customer.API.Models
{
    public partial class BMSCustomerContext : DbContext
    {
        public BMSCustomerContext()
        {
        }

        public BMSCustomerContext(DbContextOptions<BMSCustomerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BMS.Customer;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.FullName).HasMaxLength(254);

                entity.Property(e => e.Password).HasMaxLength(254);

                entity.Property(e => e.UserName).HasMaxLength(254);
            });
        }
    }
}
