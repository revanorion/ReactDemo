using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("V_ITEM_MASTER")]
    public class ItemMasterView
    {
        [Key]
        [Column("ITEM_MASTER_SEQ")]
        public int ItemMasterSeq { get; set; }

        [Column("SKU")]
        public string SKU { get; set; }

        [Column("STOCK_TYPE")]
        public string StockType { get; set; }

        [Column("COMMODITY_CODE")]
        public string CommodityCode { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Column("ROTATING")]
        public bool Rotating { get; set; }

        [Column("SDS")]
        public bool SDS { get; set; }
    }
}
