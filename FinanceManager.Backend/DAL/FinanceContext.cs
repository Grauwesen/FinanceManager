using FinanceManager.Backend.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FinanceManager.Backend.DAL
{
    public class FinanceContext : DbContext
    {
        public FinanceContext() : base("FinanceContext")
        {
        }

        public DbSet<Process> Processes { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<Month> Months { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
