using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("REQUEST_ITEM")]
    public partial class RequestItem : ITrackable
    {
        [Key]
        [Column("REQUEST_ITEM_SEQ")]
        public int RequestItemSeq { get; set; }

        [Column("REQUEST_SEQ")]
        public int RequestSeq { get; set; }

        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [Column("IS_REPLACEMENT_ITEM")]
        public bool IsReplacementItem { get; set; }

        [StringLength(260)]
        [Column("REPLACEMENT_COMMENTS")]
        public string ReplacementComments { get; set; }

        [Required]
        [Column("QUANTITY_REQUESTED")]
        public int QuantityRequested { get; set; }

        [Column("TRACKING_VALUE")]
        public int? TrackingValue { get; set; }

        [Column("WORK_ORDER_NUMBER")]
        public int? WorkOrderNumber { get; set; }

        [Column("DESTINATION_STOREROOM_SEQ")]
        public int? DestinationStoreroomSeq { get; set; }

        [Column("IS_TRANSFER")]
        public bool IsTransfer { get; set; }

        public virtual Item Item { get; set; }

        public virtual Request Request { get; set; }

        //public virtual WorkOrder WorkOrder { get; set; }

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
            get { return RequestItemSeq; }
        }

        #endregion
    }
}
