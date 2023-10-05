namespace Final.Model.BuildPCModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomPCOrder")]
    public partial class CustomPCOrder
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string InvoiceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string OrderID { get; set; }

        [Required]
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
        [StringLength(100)]
        public string BrandName { get; set; }

        [Required]
        [StringLength(10)]
        public string CategoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        public virtual Accessory Accessory { get; set; }

        public virtual AccessoryBrand AccessoryBrand { get; set; }

        public virtual AccessoryCategory AccessoryCategory { get; set; }

        public virtual CustomPCInvoice CustomPCInvoice { get; set; }
    }
}