using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("REQUEST")]
    public partial class Request : ITrackable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            RequestItems = new HashSet<RequestItem>();
        }

        [Key]
        [Column("REQUEST_SEQ")]
        public int RequestSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Column("STOREROOM_SEQ")]
        public int StoreroomSeq { get; set; }

        [Column("REQUEST_STATUS_SEQ")]
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

        [StringLength(2000)]
        [Column("COMMENTS")]
        public string Comments { get; set; }

        [Column("TRACKING_VALUE")]
        public int? TrackingValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestItem> RequestItems { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Request> Requests { get; set; }

        public virtual RequestStatus RequestStatus { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        public virtual Storeroom Storeroom { get; set; }

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
            get { return RequestSeq; }
        }

        #endregion
    }
}
