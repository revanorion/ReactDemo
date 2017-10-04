namespace InventoryManager.Data.DTOs
{
    public class UserView
    {
        public int UserSeq { get; set; }

        public string UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string MiddleInitial { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }          

        public int? DepartmentSeq { get; set; }

        public int? DivisionSeq { get; set; }
        public string Phone { get; set; }
        public int? SupSeq { get; set; }
        public string SupName { get; set; }

    }
}
