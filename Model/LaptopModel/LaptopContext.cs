using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Final.Model.LaptopModel {
    public partial class LaptopContext : DbContext {
        public LaptopContext()
            : base("name=LaptopContext") {
        }

        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Laptop> Laptops { get; set; }
        public virtual DbSet<LaptopBrand> LaptopBrands { get; set; }
        public virtual DbSet<LaptopOrder> LaptopOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Invoice>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.LaptopOrders)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laptop>()
                .Property(e => e.LaptopID)
                .IsUnicode(false);

            modelBuilder.Entity<Laptop>()
                .Property(e => e.SellPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Laptop>()
                .HasMany(e => e.LaptopOrders)
                .WithRequired(e => e.Laptop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaptopBrand>()
                .HasMany(e => e.Laptops)
                .WithRequired(e => e.LaptopBrand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaptopOrder>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<LaptopOrder>()
                .Property(e => e.LaptopID)
                .IsUnicode(false);

            modelBuilder.Entity<LaptopOrder>()
                .Property(e => e.SellPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LaptopOrder>()
                .Property(e => e.BuyPrice)
                .HasPrecision(18, 0);
        }
    }
}
