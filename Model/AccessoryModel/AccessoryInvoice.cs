namespace Final.Model.AccessoryModel {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AccessoryInvoice")]
    public partial class AccessoryInvoice {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccessoryInvoice() {
            AccessoryOrders = new HashSet<AccessoryOrder>();
        }

        [Key]
        [StringLength(6)]
        public string InvoiceID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessoryOrder> AccessoryOrders { get; set; }
    }
}
