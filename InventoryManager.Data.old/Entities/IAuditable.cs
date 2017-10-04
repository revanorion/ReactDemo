using System;

namespace InventoryManager.Data.Entities
{
    public interface IAuditable
    {
        DateTime Timestamp { get; set; }
    }
}
