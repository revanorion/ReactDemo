using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ITEM_RETURNED")]
    public partial class ItemReturned : ITrackable
    {
        [Key]
        [Column("ITEM_RETURNED_SEQ")]
        public int ItemReturnedSeq { get; set; }

        [Column("ITEM_ISSUED_SEQ")]
        public int ItemIssuedSeq { get; set; }

        [Column("QUANTITY_RETURNED")]
        public int QuantityReturned { get; set; }

        [Column("RETURN_DATE")]
        public DateTime ReturnDate { get; set; }

        [Column("RETURN_CONDITION")]
        public int? ReturnCondition { get; set; }

        [StringLength(4000)]
        [Column("NOTES")]
        public string Notes { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        public virtual ItemIssued ItemIssued { get; set; }

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
            get { return ItemReturnedSeq; }
        }

        #endregion
    }
}
