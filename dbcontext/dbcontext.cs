using Microsoft.EntityFrameworkCore;
using WiredBrainApp.entities;
namespace WiredBrainApp.Dbcontext
{

    public class DbStorageContext : DbContext
    {
        public DbSet<Employee> employees => Set<Employee>();
        public DbSet<Organisation> organisations => Set<Organisation>();
    }

    protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.onConfiguring(optionsBuilder);
		optionsBuilder.UseInMemoryDatabase("WiredBrainDb");
	}
        
}