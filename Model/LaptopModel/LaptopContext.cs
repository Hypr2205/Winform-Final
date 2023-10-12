using System.Data.Entity;

namespace Final.Model.LaptopModel {
    public partial class LaptopContext : DbContext {
        public LaptopContext()
            : base("name=LaptopContext") {
        }

        public virtual DbSet<Laptop> Laptops { get; set; }
        public virtual DbSet<LaptopCategory> LaptopCategories { get; set; }
        public virtual DbSet<LaptopInvoice> LaptopInvoices { get; set; }
        public virtual DbSet<LaptopOrder> LaptopOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
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

            modelBuilder.Entity<LaptopCategory>()
                .HasMany(e => e.Laptops)
                .WithRequired(e => e.LaptopCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaptopCategory>()
                .HasMany(e => e.LaptopOrders)
                .WithRequired(e => e.LaptopCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaptopInvoice>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<LaptopInvoice>()
                .HasMany(e => e.LaptopOrders)
                .WithRequired(e => e.LaptopInvoice)
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
