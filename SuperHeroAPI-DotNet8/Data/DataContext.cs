using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI_DotNet8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // Define your DbSets here
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
