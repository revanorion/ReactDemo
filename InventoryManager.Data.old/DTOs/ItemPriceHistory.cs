using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Data.DTOs
{
    public class ItemPriceHistory
    {
        public int ItemPriceHistorySeq { get; set; }

        public int ItemSeq { get; set; }

        public decimal ChangedToPrice { get; set; }

        public decimal ChangedFromPrice { get; set; }
        
        [Required]
        [StringLength(250)]
        public string ChangedToUnit { get; set; }

        [StringLength(250)]
        public string ChangedFromUnit { get; set; }

        public DateTime ChangedOn { get; set; }

        public int ChangedBy { get; set; }

        [StringLength(20)]
        public string Source { get; set; }

        #region IAuditable Properties
        public DateTime Timestamp { get; set; }
        #endregion
    }
}