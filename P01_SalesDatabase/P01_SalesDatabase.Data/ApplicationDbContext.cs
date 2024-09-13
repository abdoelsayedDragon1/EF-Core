using Microsoft.EntityFrameworkCore;
using P01_SalesDatabase.P01_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.P01_SalesDatabase.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("server= localhost; Initial Catalog= Sales; Integrated Security = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsUnicode(true);



            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .IsUnicode(true);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Email)
                .HasMaxLength(80);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                 .Property(c => c.CreaditCardNumber)
                 .HasColumnType("varchar(50)");


            modelBuilder.Entity<Store>()
                .Property(s => s.Name)
                .HasMaxLength(80);

            modelBuilder.Entity<Store>()
               .Property(S => S.Name)
               .IsUnicode(true);

            modelBuilder.Entity<Product>()
                .Property (p => p.Description)
                .HasMaxLength(500)
                .IsUnicode (false);


        }
    }
}
