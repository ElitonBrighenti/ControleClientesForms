namespace ControleClientes
{
    public class ClienteRepository
    {
        private List<Cliente> clientes = new List<Cliente>();
        private int nextId = 1;

        public List<Cliente> ReadAll() => clientes;

        public void Create(Cliente cliente)
        {
            cliente.Id = nextId;
            clientes.Add(cliente);
            nextId++;
        }

        public Cliente GetById(int id) => clientes.FirstOrDefault(c => c.Id == id);        

        public void Update(Cliente cliente)
        {
            Cliente clienteExistente = GetById(cliente.Id);
            if (clienteExistente != null) 
            { 
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Email = cliente.Email;
            }
        }

        public void Delete(Cliente cliente)
        {
            Cliente clienteExistente = GetById(cliente.Id);
            if (clienteExistente != null)
            {
                clientes.Remove(clienteExistente);
            }
        }
    }
}
