using Poc.UnitTests.Business.Interfaces;
using Poc.UnitTests.DTOs;
using Poc.UnitTests.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Poc.UnitTests.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteBusiness _clienteBusiness;
        public ClienteServices(IClienteBusiness clienteBusiness)
        {
            _clienteBusiness = clienteBusiness;
        }
        public async Task<int> Inserir(ClienteDTO clienteDTO)
        {
            bool clienteValido = _clienteBusiness.Validar(clienteDTO);
            if(!clienteValido)
            {
                throw new Exception("Cliente inválido");
            }

            int Id = await _clienteBusiness.Inserir(clienteDTO);
            return Id;
        }
    }
}
