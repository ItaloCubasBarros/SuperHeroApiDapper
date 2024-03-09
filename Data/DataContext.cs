using Microsoft.EntityFrameworkCore;
using SuperHeroApi_DotNet8.Entity;

namespace SuperHeroApi_DotNet8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
