using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManager.Data.Entities
{
    [Table("V_PERSON")]
    public class UserView
    {
        [Key]
        [Column("PERSON_SEQ")]
        public int UserSeq { get; set; }

        [Column("USER_ID")]
        public string UserId { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("FIRST_NAME")]
        public string FirstName { get; set; }

        [Column("MIDDLE_INIT")]
        public string MiddleInitial { get; set; }

        [Column("LAST_NAME")]
        public string LastName { get; set; }

        [Column("FULL_NAME")]
        public string FullName { get; set; }

       
        [Column("DEPT_SEQ")]
        public int? DepartmentSeq { get; set; }

        [Column("DIV_SEQ")]
        public int? DivisionSeq { get; set; }
        
        [Column("PHONE")]
        public string Phone { get; set; }
        [Column("SUP_SEQ")]
        public int? SupSeq { get; set; }
        [Column("SUP_NAME")]
        public string SupName { get; set; }
    }
}
