using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Final.Model.BuildPCModel {
    public partial class BuildPcDBContext : DbContext {
        public BuildPcDBContext()
            : base("name=BuildPcDBContext") {
        }

        public virtual DbSet<Accessory> Accessories { get; set; }
        public virtual DbSet<AccessoryBrand> AccessoryBrands { get; set; }
        public virtual DbSet<AccessoryCategory> AccessoryCategories { get; set; }
        public virtual DbSet<CustomPCInvoice> CustomPCInvoices { get; set; }
        public virtual DbSet<CustomPCOrder> CustomPCOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Accessory>()
                .Property(e => e.AccessoryID)
                .IsUnicode(false);

            modelBuilder.Entity<Accessory>()
                .Property(e => e.SalePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Accessory>()
                .Property(e => e.BrandID)
                .IsUnicode(false);

            modelBuilder.Entity<Accessory>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<Accessory>()
                .HasMany(e => e.CustomPCOrders)
                .WithRequired(e => e.Accessory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryBrand>()
                .Property(e => e.BrandID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessoryBrand>()
                .HasMany(e => e.Accessories)
                .WithRequired(e => e.AccessoryBrand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryBrand>()
                .HasMany(e => e.CustomPCOrders)
                .WithRequired(e => e.AccessoryBrand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryCategory>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessoryCategory>()
                .HasMany(e => e.Accessories)
                .WithRequired(e => e.AccessoryCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryCategory>()
                .HasMany(e => e.CustomPCOrders)
                .WithRequired(e => e.AccessoryCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomPCInvoice>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomPCInvoice>()
                .HasMany(e => e.CustomPCOrders)
                .WithRequired(e => e.CustomPCInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.AccessoryID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.SellPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.BrandID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.BuyPrice)
                .HasPrecision(18, 0);
        }
    }
}
