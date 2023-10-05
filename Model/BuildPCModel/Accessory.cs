namespace Final.Model.BuildPCModel
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
            CustomPCOrder = new HashSet<CustomPCOrder>();
        }

        [StringLength(10)]
        public string AccessoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string AccessoryName { get; set; }

        public decimal SalePrice { get; set; }

        public int Sale { get; set; }

        [Required]
        [StringLength(10)]
        public string BrandID { get; set; }

        [Required]
        [StringLength(10)]
        public string CategoryID { get; set; }

        public virtual AccessoryBrand AccessoryBrand { get; set; }

        public virtual AccessoryCategory AccessoryCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomPCOrder> CustomPCOrder { get; set; }
    }
}
