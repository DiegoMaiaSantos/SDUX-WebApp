using Microsoft.EntityFrameworkCore;
using SDUX_Camed_02.Entities;

namespace SDUX_Camed_02.Data
{
    public class CamedDbContext : DbContext
    {
        public CamedDbContext(DbContextOptions<CamedDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
