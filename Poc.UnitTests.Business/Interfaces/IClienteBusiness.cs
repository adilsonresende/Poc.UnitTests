using Poc.UnitTests.DTOs;
using System.Threading.Tasks;

namespace Poc.UnitTests.Business.Interfaces
{
    public interface IClienteBusiness
    {
        bool Validar(ClienteDTO clienteDTO);
        Task<int> Inserir(ClienteDTO clienteDTO);
    }
}
