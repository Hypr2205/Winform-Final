namespace Final.Model.LaptopModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LaptopOrder")]
    public partial class LaptopOrder
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
        public string LaptopID { get; set; }

        [Required]
        [StringLength(100)]
        public string LaptopName { get; set; }

        public decimal SellPrice { get; set; }

        public int Sale { get; set; }

        [Required]
        [StringLength(10)]
        public string CategoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        public virtual Laptop Laptop { get; set; }

        public virtual LaptopCategory LaptopCategory { get; set; }

        public virtual LaptopInvoice LaptopInvoice { get; set; }
    }
}
