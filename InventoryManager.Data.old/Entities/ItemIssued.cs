using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ITEM_ISSUED")]
    public partial class ItemIssued : ITrackable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemIssued()
        {
            ItemIssuedReceived = new HashSet<ItemIssuedReceived>();
            ItemsReturned = new HashSet<ItemReturned>();
        }

        [Key]
        [Column("ITEM_ISSUED_SEQ")]
        public int ItemIssuedSeq { get; set; }

        [Column("DATE_ISSUED")]
        public DateTime DateIssued { get; set; }

        [Column("REQUEST_ITEM_SEQ")]
        public int RequestItemSeq { get; set; }

        [Column("QUANTITY_ISSUED")]
        public int QuantityIssued { get; set; }

        [Column("ISSUE_PRICE")]
        public decimal? IssuePrice { get; set; }

        [Column("ISSUE_UNIT_SEQ")]
        public int IssueUnitSeq { get; set; }

        [Column("ISSUE_CONDITION")]
        public int? IssueCondition { get; set; }

        [Column("IS_LOAN_ITEM")]
        public bool IsLoanItem { get; set; }

        [Column("LOAN_EXPIRATION")]
        public DateTime? LoanExpiration { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        public virtual IssueUnit IssueUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemIssuedReceived> ItemIssuedReceived { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemReturned> ItemsReturned { get; set; }

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
            get { return ItemIssuedSeq; }
        }

        #endregion
    }
}
