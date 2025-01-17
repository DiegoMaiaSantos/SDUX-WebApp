using Microsoft.EntityFrameworkCore;
using SDUX_Camed_03.Entities;

namespace SDUX_Camed_03.Data
{
    public class CamedDbContext : DbContext
    {
        public CamedDbContext(DbContextOptions<CamedDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
