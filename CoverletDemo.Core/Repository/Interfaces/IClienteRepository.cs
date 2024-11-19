public interface IClienteRepository
{
    Cliente GetClienteById(int id);
    List<Cliente> GetAllClientes();
}
