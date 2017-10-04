using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("REQUEST_HISTORY")]
    public partial class RequestHistory : IAuditable
    {
        [Key]
        [Column("REQUEST_SEQ", Order = 0)]
        public int RequestSeq { get; set; }

        [Key]
        [Column("WAREHOUSE_SEQ", Order = 1)]
        public int WarehouseSeq { get; set; }

        [Key]
        [Column("REQUEST_STATUS_SEQ", Order = 2)]
        public int RequestStatusSeq { get; set; }

        [Column("REQUESTED_ON")]
        public DateTime? RequestedOn { get; set; }

        [Column("REQUESTED_BY")]
        public int? RequestedBy { get; set; }

        [Column("APPROVED_ON")]
        public DateTime? ApprovedOn { get; set; }

        [Column("APPROVED_BY")]
        public int? ApprovedBy { get; set; }

        [Column("ISSUED_ON")]
        public DateTime? IssuedOn { get; set; }

        [Column("ISSUED_BY")]
        public int? IssuedBy { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        [Column("TRACKING_VALUE")]
        public int? TrackingValue { get; set; }

        public virtual RequestStatus RequestStatus { get; set; }

        #region IAuditable Properties
        [Column("TIMESTAMP")]
        public DateTime Timestamp { get; set; }
        #endregion
    }
}
