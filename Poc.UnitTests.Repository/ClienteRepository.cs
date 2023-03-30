using Poc.UnitTests.DTOs;
using Poc.UnitTests.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace Poc.UnitTests.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public async Task<int> Inserir(ClienteDTO clienteDTO)
        {
            await Task.Delay(1);
            return 1;
        }
    }
}
