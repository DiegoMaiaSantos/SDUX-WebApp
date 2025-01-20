using AutoMapper;
using SDUX_Camed_API_02.Entities;
using SDUX_Camed_API_02.Interfaces.Repositories;
using SDUX_Camed_API_02.Interfaces.Services;
using SDUX_Camed_API_02.Models;

namespace SDUX_Camed_API_02.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClienteModel>> GetListClienteAsync()
        {
            try
            {
                IEnumerable<Cliente> resultList = await _clienteRepository.GetListAsync();

                if (resultList == null)
                    throw new Exception("A lista de clientes está vazia.");

                IEnumerable<ClienteModel> mappedList = _mapper.Map<IEnumerable<ClienteModel>>(resultList);

                return mappedList;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter lista de clientes.", ex);
            }
        }

        public async Task<ClienteModel> GetByIdAsync(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("ID inválido", nameof(id));

                Cliente cliente = await _clienteRepository.FindByIdAsync(id);

                if (cliente == null)
                    throw new KeyNotFoundException($"Cliente com o ID {id} não foi encontrado.");

                ClienteModel clienteMapped = _mapper.Map<ClienteModel>(cliente);

                return clienteMapped;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> PostCliente(ClienteModel model)
        {
            try
            {
                Cliente cliente = _mapper.Map<Cliente>(model);

                if (await _clienteRepository.Post(cliente))
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateCliente(ClienteModel model)
        {
            try
            {
                if (model.Id <= 0)
                    throw new ArgumentException("ID inválido", nameof(model.Id));

                Cliente existingCliente = await _clienteRepository.FindByIdAsync(model.Id);

                if (existingCliente == null)
                    throw new KeyNotFoundException($"Cliente com o ID {model.Id} não foi encontrado.");

                _mapper.Map(model, existingCliente);

                if (await _clienteRepository.Update(existingCliente))
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteCliente(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("ID inválido", nameof(id));

                Cliente existingCliente = await _clienteRepository.FindByIdAsync(id);

                if (existingCliente == null)
                    throw new KeyNotFoundException($"Cliente com o ID {id} não foi encontrado.");

                if (await _clienteRepository.Delete(existingCliente))
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
