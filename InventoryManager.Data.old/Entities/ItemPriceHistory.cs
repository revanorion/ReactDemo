using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("ITEM_PRICE_HISTORY")]
    public partial class ItemPriceHistory : IAuditable
    {
        [Key]
        [Column("ITEM_PRICE_HISTORY_SEQ")]
        public int ItemPriceHistorySeq { get; set; }

        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [Required]
        [Column("CHANGED_TO_PRICE")]
        public decimal ChangedToPrice { get; set; }

        [Required]
        [Column("CHANGED_FROM_PRICE")]
        public decimal ChangedFromPrice { get; set; }

        [Column("CHANGED_TO_UNIT")]
        public int? ChangedToUnit { get; set; }

        [Column("CHANGED_FROM_UNIT")]
        public int? ChangedFromUnit { get; set; }

        [Column("CHANGED_ON")]
        public DateTime ChangedOn { get; set; }

        [Column("CHANGED_BY")]
        public int ChangedBy { get; set; }

        [StringLength(20)]
        [Column("SOURCE")]
        public string Source { get; set; }

        public virtual Item Item { get; set; }

        public virtual IssueUnit IssueUnit { get; set; }

        #region IAuditable Properties
        [Column("TIMESTAMP")]
        public DateTime Timestamp { get; set; }
        #endregion
    }
}
