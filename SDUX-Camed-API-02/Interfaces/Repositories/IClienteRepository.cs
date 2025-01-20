using SDUX_Camed_API_02.Entities;

namespace SDUX_Camed_API_02.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetListAsync();
        Task<Cliente> FindByIdAsync(int id);
        Task<bool> Post(Cliente cliente);
        Task<bool> Update(Cliente cliente);
        Task<bool> Delete(Cliente cliente);
    }
}
