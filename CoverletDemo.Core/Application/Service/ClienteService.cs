

using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
public class ClienteService
{
    private readonly IClienteRepository _clienteRepository;


    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public Cliente GetCliente(int id)
    {
        return _clienteRepository.GetClienteById(id);
    }

    public List<Cliente> GetTodosClientes()
    {
        return _clienteRepository.GetAllClientes();
    }
}
