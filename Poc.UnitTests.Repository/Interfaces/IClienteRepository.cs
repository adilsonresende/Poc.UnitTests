using Poc.UnitTests.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.UnitTests.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<int> Inserir(ClienteDTO clienteDTO);
    }
}
