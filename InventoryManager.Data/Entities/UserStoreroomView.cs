using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("V_USER_STOREROOM")]
    public partial class UserStoreroomView
    {
        [Key]
        [Column("USER_STOREROOM_SEQ")]
        public int UserStoreroomSeq { get; set; }

        [Column("USER_ID")]
        public string UserId { get; set; }

        [Column("USER_SEQ")]
        public int UserSeq { get; set; }

        [Column("STOREROOM_SEQ")]
        public int StoreroomSeq { get; set; }

        [Column("STOREROOM_NAME")]
        public string StoreroomName { get; set; }

        [Column("IS_DEFAULT_STOREROOM")]
        public bool IsDefaultStoreroom { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Column("IS_VEHICLE")]
        public bool IsVehicle { get; set; }

        [Column("IS_ACTIVE")]
        public bool IsActive { get; set; }

        [Column("REGION_SEQ")]
        public int RegionSeq { get; set; }
    }
}
