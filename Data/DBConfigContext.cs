using Microsoft.EntityFrameworkCore;
using retroBackend.Class;

namespace retroBackend.Data
{
    public class DBConfigContext : DbContext
    {
        public DBConfigContext(DbContextOptions<DBConfigContext> options) : base(options) { }
        public DbSet<Master> master { get; set; }
    }
}
