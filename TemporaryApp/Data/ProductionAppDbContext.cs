using Microsoft.EntityFrameworkCore;
using ProductionApp.Entities;

namespace ProductionApp.Data
{
    public class ProductionAppDbContext : DbContext
    {
        public DbSet<Machine> Machines => Set<Machine>();

        public DbSet<AgvOnLogistic> AgvOnLogistics => Set<AgvOnLogistic>();
        public DbSet<Printer> Printers => Set<Printer>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
