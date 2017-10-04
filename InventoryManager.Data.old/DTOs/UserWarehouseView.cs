using System;

namespace InventoryManager.Data.DTOs
{
    [Serializable]
    public class UserWarehouseView
    {
        public int UserWarehouseSeq { get; set; }

        public string UserId { get; set; }

        public int UserSeq { get; set; }

        public int WarehouseSeq { get; set; }

        public string WarehouseName { get; set; }

        public bool HasAdvancedFeatures { get; set; }
    }
}
