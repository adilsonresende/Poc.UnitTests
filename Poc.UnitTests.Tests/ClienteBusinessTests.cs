using Moq;
using NUnit.Framework;
using Poc.UnitTests.Business;
using Poc.UnitTests.DTOs;
using Poc.UnitTests.Repository;
using Poc.UnitTests.Repository.Interfaces;

namespace Poc.UnitTests.Tests
{
    public class Tests
    {
        private Mock<IClienteRepository> _clienteRepository;
        private ClienteBusiness _clienteBusiness;

        [SetUp]
        public void Setup()
        {
            _clienteRepository = new Mock<IClienteRepository>();
            _clienteBusiness = new ClienteBusiness(_clienteRepository.Object);
        }

        [Test]
        public void Validar_ClienteValido_RetornaTrue()
        {
            //Arrange
            bool resultadoEsperado = true;
            ClienteDTO clienteDTO = new ClienteDTO { Nome = "Nome", Sobrenome = "Sobrenome", DataNascimento = new System.DateTime(2000, 01, 01)};

            //Act
            bool resultado = _clienteBusiness.Validar(clienteDTO);

            //Assert
            Assert.That(resultado, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void Validar_ClienteInValido_RetornaFalse()
        {
            //Arrange
            bool resultadoEsperado = false;
            ClienteDTO clienteDTO = new ClienteDTO { Nome = "Nome", Sobrenome = string.Empty, DataNascimento = new System.DateTime(2000, 01, 01) };

            //Act
            bool resultado = _clienteBusiness.Validar(clienteDTO);

            //Assert
            Assert.That(resultado, Is.EqualTo(resultadoEsperado));
        }
    }
}