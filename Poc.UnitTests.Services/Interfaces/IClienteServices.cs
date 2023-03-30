using Poc.UnitTests.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.UnitTests.Services.Interfaces
{
    public interface IClienteServices
    {
        Task<int> Inserir(ClienteDTO clienteDTO);
    }
}
