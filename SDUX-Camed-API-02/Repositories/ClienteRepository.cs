using Microsoft.EntityFrameworkCore;
using SDUX_Camed_API_02.Data;
using SDUX_Camed_API_02.Entities;
using SDUX_Camed_API_02.Interfaces.Repositories;

namespace SDUX_Camed_API_02.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CamedDbContext _context;

        public ClienteRepository(CamedDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetListAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> FindByIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<bool> Post(Cliente cliente)
        {
            await _context.Clientes.AddRangeAsync(cliente);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(Cliente cliente)
        {
            _context.Remove(cliente);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
