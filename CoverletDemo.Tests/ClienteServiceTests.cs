using Moq;
using Xunit;
using System.Collections.Generic;

namespace CoverletDemo.Tests
{
    public class ClienteServiceTests
    {
        [Fact]
        public void GetCliente_RetornaCliente_QuandoIdValido()
        {
            // Arrange: Configura o mock
            var mockClienteRepo = new Mock<IClienteRepository>();
            var clienteEsperado = new Cliente { Id = 1, Nome = "João", Email = "joao@example.com" };

            // Configurando o mock para retornar o cliente esperado
            mockClienteRepo.Setup(repo => repo.GetClienteById(1)).Returns(clienteEsperado);

            var clienteService = new ClienteService(mockClienteRepo.Object);

            // Act: Executa o método
            var resultado = clienteService.GetCliente(1);

            // Assert: Verifica se o cliente retornado é o esperado
            Assert.Equal(clienteEsperado, resultado);
        }

        [Fact]
        public void GetTodosClientes_RetornaListaDeClientes()
        {
            // Arrange: Configura o mock
            var mockClienteRepo = new Mock<IClienteRepository>();
            var clientesEsperados = new List<Cliente>
            {
                new Cliente { Id = 1, Nome = "João", Email = "joao@example.com" },
                new Cliente { Id = 2, Nome = "Maria", Email = "maria@example.com" }
            };

            // Configurando o mock para retornar a lista de clientes
            mockClienteRepo.Setup(repo => repo.GetAllClientes()).Returns(clientesEsperados);

            var clienteService = new ClienteService(mockClienteRepo.Object);

            // Act: Executa o método
            var resultado = clienteService.GetTodosClientes();

            // Assert: Verifica se a lista de clientes é a esperada
            Assert.Equal(clientesEsperados.Count, resultado.Count);
            Assert.Equal(clientesEsperados[0].Nome, resultado[0].Nome);
            Assert.Equal(clientesEsperados[1].Nome, resultado[1].Nome);
        }
    }
}
