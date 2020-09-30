using Microsoft.EntityFrameworkCore;

namespace BrainWorks.ATM.Data
{
    public class ATMContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    
    {
            string connectionString = "Data Source =SATYA\\SQLEXPRESS ; Initial Catalog = ATMDB; Integrated Security = True";
            optionsBuilder.UseSqlServer(connectionString);
    }
}
}