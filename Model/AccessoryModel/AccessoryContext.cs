using System.Data.Entity;

namespace Final.Model.AccessoryModel {
    public partial class AccessoryContext : DbContext {
        public AccessoryContext()
            : base("name=AccessoryContext") {
        }

        public virtual DbSet<Accessory> Accessories { get; set; }
        public virtual DbSet<AccessoryBrand> AccessoryBrands { get; set; }
        public virtual DbSet<AccessoryCategory> AccessoryCategories { get; set; }
        public virtual DbSet<AccessoryInvoice> AccessoryInvoices { get; set; }
        public virtual DbSet<AccessoryOrder> AccessoryOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Accessory>()
                .Property(e => e.AccessoryID)
                .IsUnicode(false);

            modelBuilder.Entity<Accessory>()
                .Property(e => e.SellPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Accessory>()
                .HasMany(e => e.AccessoryOrders)
                .WithRequired(e => e.Accessory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryBrand>()
                .HasMany(e => e.Accessories)
                .WithRequired(e => e.AccessoryBrand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryCategory>()
                .HasMany(e => e.Accessories)
                .WithRequired(e => e.AccessoryCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryInvoice>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessoryInvoice>()
                .HasMany(e => e.AccessoryOrders)
                .WithRequired(e => e.AccessoryInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessoryOrder>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessoryOrder>()
                .Property(e => e.AccessoryID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessoryOrder>()
                .Property(e => e.SellPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AccessoryOrder>()
                .Property(e => e.BuyPrice)
                .HasPrecision(18, 0);
        }
    }
}
