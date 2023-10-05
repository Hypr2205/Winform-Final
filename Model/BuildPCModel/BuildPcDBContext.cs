using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Final.Model.BuildPCModel {
    public partial class BuildPcDBContext : DbContext {
        public BuildPcDBContext()
            : base("name=BuildPcDBContext") {
        }

        public virtual DbSet<Accessory> Accessory { get; set; }
        public virtual DbSet<AccessoryBrand> AccessoryBrand { get; set; }
        public virtual DbSet<AccessoryCategory> AccessoryCategory { get; set; }
        public virtual DbSet<CustomPCInvoice> CustomPCInvoice { get; set; }
        public virtual DbSet<CustomPCOrder> CustomPCOrder { get; set; }

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
                .HasMany(e => e.CustomPCOrder)
                .WithRequired(e => e.Accessory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryBrand>()
                .Property(e => e.BrandID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessoryBrand>()
                .HasMany(e => e.Accessory)
                .WithRequired(e => e.AccessoryBrand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryBrand>()
                .HasMany(e => e.CustomPCOrder)
                .WithRequired(e => e.AccessoryBrand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryCategory>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessoryCategory>()
                .HasMany(e => e.Accessory)
                .WithRequired(e => e.AccessoryCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryCategory>()
                .HasMany(e => e.CustomPCOrder)
                .WithRequired(e => e.AccessoryCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomPCInvoice>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomPCInvoice>()
                .HasMany(e => e.CustomPCOrder)
                .WithRequired(e => e.CustomPCInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.AccessoryID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.SalePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.BrandID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomPCOrder>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);
        }
    }
}
