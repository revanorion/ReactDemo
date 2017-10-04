using System;

namespace InventoryManager.Data.DTOs
{
    [Serializable]
    public class UserStoreroomView
    {
        public int UserStoreroomSeq { get; set; }

        public string UserId { get; set; }

        public int UserSeq { get; set; }

        public int StoreroomSeq { get; set; }

        public string StoreroomName { get; set; }

        public bool IsDefaultStoreroom { get; set; }

        public int WarehouseSeq { get; set; }

        public bool IsVehicle { get; set; }

        public bool IsActive { get; set; }

        public int RegionSeq { get; set; }
    }
}
