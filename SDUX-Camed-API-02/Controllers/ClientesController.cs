using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SDUX_Camed_API_02.Entities;
using SDUX_Camed_API_02.Interfaces.Services;
using SDUX_Camed_API_02.Models;

namespace SDUX_Camed_API_02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarListaClientes()
        {
            IEnumerable<ClienteModel> listClient = await _clienteService.GetListClienteAsync();

            return Ok(listClient);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarClientePorId(int id)
        {
            ClienteModel cliente = await _clienteService.GetByIdAsync(id);

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarCliente(ClienteModel model)
        {
            return Ok(await _clienteService.PostCliente(model));
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarCliente(ClienteModel model)
        {
            return Ok(await _clienteService.UpdateCliente(model));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarCliente(int id)
        {
            return Ok(await _clienteService.DeleteCliente(id));
        }
    }
}
