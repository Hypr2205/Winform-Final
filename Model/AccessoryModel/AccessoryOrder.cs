namespace Final.Model.AccessoryModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessoryOrder")]
    public partial class AccessoryOrder
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string InvoiceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Required]
        [StringLength(10)]
        public string AccessoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string AccessoryName { get; set; }

        public decimal SellPrice { get; set; }

        public int Sale { get; set; }

        [Required]
        [StringLength(255)]
        public string BrandName { get; set; }

        [Required]
        [StringLength(255)]
        public string CategoryName { get; set; }

        public decimal BuyPrice { get; set; }

        public int BuyQuantity { get; set; }

        public virtual Accessory Accessory { get; set; }

        public virtual AccessoryInvoice AccessoryInvoice { get; set; }
    }
}
