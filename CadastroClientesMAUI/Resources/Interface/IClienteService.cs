using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroClientesMAUI.Resources.Models;

namespace CadastroClientesMAUI.Resources.Interface
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetAllClientesAsync();
        Task<Cliente> GetClienteByIdAsync(Guid id);
        Task AddClienteAsync(Cliente cliente);
        Task UpdateClienteAsync(Cliente cliente);
        Task DeleteClienteAsync(Guid id);
    }
}
