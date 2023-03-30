using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poc.UnitTests.DTOs;
using Poc.UnitTests.Services;
using Poc.UnitTests.Services.Interfaces;
using System.Threading.Tasks;

namespace Poc.UnitTests.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServices _clienteServices;    
        public ClienteController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        [HttpPost]
        [Route(nameof(Inserir))]
        public async Task<IActionResult> Inserir([FromBody] ClienteDTO clienteDTO)
        {
            int id = await _clienteServices.Inserir(clienteDTO);
            return Ok(id);
        }
    }
}
