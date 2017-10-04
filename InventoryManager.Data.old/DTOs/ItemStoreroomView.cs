namespace InventoryManager.Data.DTOs
{
    public class ItemStoreroomView
    {
        public int ItemMasterSeq { get; set; }

        public int ItemSeq { get; set; }

        public int StoreroomSeq { get; set; }

        public int WarehouseSeq { get; set; }

        public string Storeroom { get; set; }

        public int OnHand { get; set; }

        public string StockStatus { get; set; }

        public decimal? AverageCost { get; set; }

        public decimal? LastReceiptCost { get; set; }
    }
}
