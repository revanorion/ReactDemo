using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ITEM_ISSUED_RECEIVED")]
    public partial class ItemIssuedReceived : ITrackable
    {
        [Key]
        [Column("ITEM_RECEIVED_SEQ", Order = 0)]
        public int ItemReceivedSeq { get; set; }

        [Key]
        [Column("ITEM_ISSUED_SEQ", Order = 1)]
        public int ItemIssuedSeq { get; set; }

        [Column("QUANTITY_ISSUED")]
        public int QuantityIssued { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        public virtual ItemIssued ItemIssued { get; set; }

        public virtual ItemReceived ItemReceived { get; set; }

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
            get { return ItemReceivedSeq; }
        }

        #endregion
    }
}
