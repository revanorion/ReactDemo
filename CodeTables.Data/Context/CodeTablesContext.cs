using CodeTables.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeTables.Data.Context
{
    public partial class CodeTablesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PBCSQL08DEV1;Database=Eng_accounter;user id=accounter;password=accounter;");
        }

        public virtual DbSet<ExternalPaymentType> AdjustmentReason { get; set; }     

       
    }
}
