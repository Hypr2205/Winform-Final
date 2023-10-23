namespace Final.Model.LaptopModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Laptop")]
    public partial class Laptop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Laptop()
        {
            LaptopOrders = new HashSet<LaptopOrder>();
        }

        [StringLength(10)]
        public string LaptopID { get; set; }

        [Required]
        [StringLength(100)]
        public string LaptopName { get; set; }

        public decimal SellPrice { get; set; }

        public int Sale { get; set; }

        public int BrandID { get; set; }

        public int Quantity { get; set; }

        public virtual LaptopBrand LaptopBrand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LaptopOrder> LaptopOrders { get; set; }
    }
}
