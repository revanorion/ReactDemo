using System;

namespace InventoryManager.Data.DTOs
{
    public interface IRangedClass
    {
        int? WarehouseSeq { get; set; }
        DateTime? StartDate { get; set; }
        DateTime? EndDate { get; set; }
    }
}
