using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("V_ITEM_STOREROOM")]
    public class ItemStoreroomView
    {
        [Key]
        [Column("ITEM_MASTER_SEQ")]
        public int ItemMasterSeq { get; set; }

        [Column("ITEM_SEQ")]
        public int ItemSeq { get; set; }

        [Column("STOREROOM_SEQ")]
        public int StoreroomSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Column("STOREROOM")]
        public string Storeroom { get; set; }

        [Column("ON_HAND")]
        public int OnHand { get; set; }

        [Column("STOCK_STATUS")]
        public string StockStatus { get; set; }

        [Column("AVERAGE_COST")]
        public decimal? AverageCost { get; set; }

        [Column("LAST_RECEIPT_COST")]
        public decimal? LastReceiptCost { get; set; }
    }
}
