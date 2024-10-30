using Microsoft.EntityFrameworkCore;
using retroBackend.Class;

namespace retroBackend.Data
{
    public class MasterRepository
    {
        //private readonly DBConfigContext _context = new DBConfigContext();
        DBConfigContext _context = new DBConfigContext(new DbContextOptions<DBConfigContext>());

        public async Task<List<Master>> GetMockData()
        {

            var varibe = await  _context.master.FromSqlRaw("SELECT * FROM GetMockData()").ToListAsync();
            return varibe;
        }
    }
}
