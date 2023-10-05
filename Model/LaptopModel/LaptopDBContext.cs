using System.Data.Entity;

namespace Final.Model.LaptopModel {
    public partial class LaptopDBContext : DbContext {
        public LaptopDBContext()
            : base("name=LaptopDBContext") {
        }

        public virtual DbSet<Laptop> Laptop { get; set; }
        public virtual DbSet<LaptopCategory> LaptopCategory { get; set; }
        public virtual DbSet<LaptopInvoice> LaptopInvoice { get; set; }
        public virtual DbSet<LaptopOrder> LaptopOrder { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Laptop>()
                .Property(e => e.LaptopID)
                .IsUnicode(false);

            modelBuilder.Entity<Laptop>()
                .Property(e => e.SellPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Laptop>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<Laptop>()
                .HasMany(e => e.LaptopOrder)
                .WithRequired(e => e.Laptop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaptopCategory>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<LaptopCategory>()
                .HasMany(e => e.Laptop)
                .WithRequired(e => e.LaptopCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaptopCategory>()
                .HasMany(e => e.LaptopOrder)
                .WithRequired(e => e.LaptopCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaptopInvoice>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<LaptopInvoice>()
                .HasMany(e => e.LaptopOrder)
                .WithRequired(e => e.LaptopInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LaptopOrder>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<LaptopOrder>()
                .Property(e => e.OrderID)
                .IsUnicode(false);

            modelBuilder.Entity<LaptopOrder>()
                .Property(e => e.LaptopID)
                .IsUnicode(false);

            modelBuilder.Entity<LaptopOrder>()
                .Property(e => e.SellPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LaptopOrder>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);
        }
    }
}
