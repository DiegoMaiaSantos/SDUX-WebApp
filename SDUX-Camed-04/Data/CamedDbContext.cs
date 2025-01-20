using Microsoft.EntityFrameworkCore;
using SDUX_Camed_04.Models;

namespace SDUX_Camed_04.Data
{
    public class CamedDbContext : DbContext
    {
        public CamedDbContext(DbContextOptions<CamedDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
