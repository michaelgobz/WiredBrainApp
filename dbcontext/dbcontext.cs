using Microsoft.EntityFrameworkCore;
using WiredBrainApp.entities;
namespace WiredBrainApp.Dbcontext
{

    public class DbStorageContext : DbContext
    {
        public DbSet<Employee> employees => Set<Employee>();
        public DbSet<Organisation> organisations => Set<Organisation>();
    }

    public override onConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
		optionsBuilder.UseInMemoryDatabase("database");
	}

}