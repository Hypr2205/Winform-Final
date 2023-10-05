namespace Final.Model.BuildPCModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessoryBrand")]
    public partial class AccessoryBrand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccessoryBrand()
        {
            Accessory = new HashSet<Accessory>();
            CustomPCOrder = new HashSet<CustomPCOrder>();
        }

        [Key]
        [StringLength(10)]
        public string BrandID { get; set; }

        [Required]
        [StringLength(100)]
        public string BrandName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accessory> Accessory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomPCOrder> CustomPCOrder { get; set; }
    }
}
