using System;

namespace InventoryManager.Data.Entities
{
    public interface ITrackable
    {
        int Id { get; }
        int? UserSeqEnteredBy { get; set; }
        DateTime? DateEntered { get; set; }
        int? UserSeqChangedBy { get; set; }
        DateTime? DateChanged { get; set; }
    }
}
