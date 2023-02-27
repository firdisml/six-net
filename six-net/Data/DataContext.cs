using Microsoft.EntityFrameworkCore;
using six_net.Models;

namespace six_net.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Contest> Contests => Set<Contest>();

    }
}
