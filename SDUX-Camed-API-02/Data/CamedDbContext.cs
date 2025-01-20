using Microsoft.EntityFrameworkCore;
using SDUX_Camed_API_02.Entities;

namespace SDUX_Camed_API_02.Data
{
    public class CamedDbContext : DbContext
    {
        public CamedDbContext(DbContextOptions<CamedDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.ClienteProdutos)
                .HasForeignKey(p => p.ClienteId);
        }
    }
}
