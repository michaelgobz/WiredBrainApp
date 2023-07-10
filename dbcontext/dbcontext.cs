using Microsoft.EntityFrameworkCore;
using WiredBrainApp.entities
namespace WiredBrainApp.Dbcontext
{

    public class DbStorageContext : DbContext
    {
        public <Employee> employees => Set<Employee>();
        public DbSet<Organisation> organisations => Set<Organisation>();
    }

}