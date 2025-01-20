using SDUX_Camed_API_02.Models;

namespace SDUX_Camed_API_02.Interfaces.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteModel>> GetListClienteAsync();
        Task<ClienteModel> GetByIdAsync(int id);
        Task<bool> PostCliente(ClienteModel cliente);
        Task<bool> UpdateCliente(ClienteModel cliente);
        Task<bool> DeleteCliente(int id);
    }
}
