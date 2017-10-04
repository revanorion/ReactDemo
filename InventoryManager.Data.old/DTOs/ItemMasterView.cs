namespace InventoryManager.Data.DTOs
{
    public class ItemMasterView
    {
        public int Id
        {
            get { return ItemMasterSeq; }
        }

        public int ItemMasterSeq { get; set; }

        public string SKU { get; set; }

        public string StockType { get; set; }

        public string CommodityCode { get; set; }

        public string Description { get; set; }

        public int WarehouseSeq { get; set; }

        public bool Rotating { get; set; }

        public bool SDS { get; set; }
    }
}
