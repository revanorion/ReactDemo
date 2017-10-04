using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("V_USER_WAREHOUSE")]
    public class UserWarehouseView
    {
        [Key]
        [Column("USER_WAREHOUSE_SEQ")]
        public int UserWarehouseSeq { get; set; }

        [Column("USER_ID")]
        public string UserId { get; set; }

        [Column("USER_SEQ")]
        public int UserSeq { get; set; }

        [Column("WAREHOUSE_SEQ")]
        public int WarehouseSeq { get; set; }

        [Column("WAREHOUSE_NAME")]
        public string WarehouseName { get; set; }

        [Column("ADVANCED_FEATURES")]
        public bool HasAdvancedFeatures { get; set; }
    }
}
