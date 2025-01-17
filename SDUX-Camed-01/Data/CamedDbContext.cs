using Microsoft.EntityFrameworkCore;
using SDUX_Camed_01.Models;

namespace SDUX_Camed_01.Data
{
    public class CamedDbContext : DbContext
    {
        public CamedDbContext(DbContextOptions<CamedDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
    }
}