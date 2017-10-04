using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class Order
    {
        public int OrderSeq { get; set; }

        public int WarehouseSeq { get; set; }

        [StringLength(20)]
        public string PurchaseOrder { get; set; }

        [StringLength(20)]
        public string AdvantageDocumentID { get; set; }

        public DateTime? DateRequested { get; set; }

        [DisplayName("Date Ordered")]
        public DateTime DateOrdered { get; set; }

        public DateTime? DateCompleted { get; set; }

        public decimal? InvoiceTotal { get; set; }

        [DisplayName("Requested By")]
        public int? RequestedBy { get; set; }

        [StringLength(4000)]
        public string Notes { get; set; }

        [StringLength(20)]
        public string Source { get; set; }

        #region ITrackable Properties
        public int? UserSeqEnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public int? UserSeqChangedBy { get; set; }
        public DateTime? DateChanged { get; set; }
        #endregion
    }
}