using Microsoft.EntityFrameworkCore;
using WiredBrainApp.entities;
namespace WiredBrainApp.Dbcontext
{

    public class DbStorageContext : DbContext
    {
        public DbSet<Employee> employees => Set<Employee>();
        public DbSet<Organisation> organisations => Set<Organisation>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("WiredBrainDb");
        }
    }

}