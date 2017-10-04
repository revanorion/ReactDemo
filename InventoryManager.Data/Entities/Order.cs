using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ORDER")]
    public partial class Order : ITrackable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        [Column("ORDER_SEQ")]
        public int OrderSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [StringLength(20)]
        [Column("PURCHASE_ORDER")]
        public string PurchaseOrder { get; set; }

        [StringLength(20)]
        [Column("ADVANTAGE_DOCUMENT_ID")]
        public string AdvantageDocumentID { get; set; }

        [Column("DATE_REQUESTED")]
        public DateTime? DateRequested { get; set; }

        [Column("DATE_ORDERED")]
        public DateTime DateOrdered { get; set; }

        [Column("DATE_COMPLETED")]
        public DateTime? DateCompleted { get; set; }

        [Column("INVOICE_TOTAL")]
        public decimal? InvoiceTotal { get; set; }

        [Column("REQUESTED_BY")]
        public int? RequestedBy { get; set; }

        [StringLength(4000)]
        [Column("NOTES")]
        public string Notes { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        #region ITrackable Properties
        [Column("USER_SEQ_ENT_BY")]
        public int? UserSeqEnteredBy { get; set; }
        [Column("DT_ENT")]
        public DateTime? DateEntered { get; set; }
        [Column("USER_SEQ_CHG_BY")]
        public int? UserSeqChangedBy { get; set; }
        [Column("DT_CHG")]
        public DateTime? DateChanged { get; set; }

        [NotMapped]
        public int Id
        {
            get { return OrderSeq; }
        }

        #endregion
    }
}
