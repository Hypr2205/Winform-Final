namespace Final.Model.AccessoryModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accessory")]
    public partial class Accessory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accessory()
        {
            AccessoryOrders = new HashSet<AccessoryOrder>();
        }

        [StringLength(10)]
        public string AccessoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string AccessoryName { get; set; }

        public decimal SellPrice { get; set; }

        public int Sale { get; set; }

        public int BrandID { get; set; }

        public int CategoryID { get; set; }

        public int Quantity { get; set; }

        public virtual AccessoryBrand AccessoryBrand { get; set; }

        public virtual AccessoryCategory AccessoryCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessoryOrder> AccessoryOrders { get; set; }
    }
}
