using Poc.UnitTests.Business.Interfaces;
using Poc.UnitTests.DTOs;
using Poc.UnitTests.Repository.Interfaces;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Poc.UnitTests.Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteBusiness(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<int> Inserir(ClienteDTO clienteDTO)
        {
            int Id = await _clienteRepository.Inserir(clienteDTO);
            return Id;
        }

        public bool Validar(ClienteDTO clienteDTO)
        {
            bool clienteValido = true;
            if (string.IsNullOrWhiteSpace(clienteDTO.Nome) || string.IsNullOrEmpty(clienteDTO.Sobrenome) || (clienteDTO.DataNascimento < new DateTime(1900, 01, 01)))
            {
                clienteValido = false;
            }

            return clienteValido;
        }
    }
}
