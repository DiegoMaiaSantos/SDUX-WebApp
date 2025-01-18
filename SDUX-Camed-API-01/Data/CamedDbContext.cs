using Microsoft.EntityFrameworkCore;
using SDUX_Camed_API_01.Entities;

namespace SDUX_Camed_API_01.Data
{
    public class CamedDbContext : DbContext
    {
        public CamedDbContext(DbContextOptions<CamedDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
