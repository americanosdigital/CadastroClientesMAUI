using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using CadastroClientesMAUI.Resources.Interface;
using CadastroClientesMAUI.Resources.Models;


namespace CadastroClientesMAUI.Resources.Sevices
{
    public class ClienteService : IClienteService
    {
        private readonly HttpClient _httpClient;

        public ClienteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Cliente>> GetAllClientesAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:7023/api/Cliente");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Cliente>>();
        }

        public async Task<Cliente> GetClienteByIdAsync(Guid id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:7023/api/Cliente/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Cliente>();
        }

        public async Task AddClienteAsync(Cliente cliente)
        {
            var response = await _httpClient.PostAsJsonAsync("https://localhost:7023/api/Cliente", cliente);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateClienteAsync(Cliente cliente)
        {
            var response = await _httpClient.PutAsJsonAsync($"https://localhost:7023/api/Cliente/{cliente.Id}", cliente);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteClienteAsync(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7023/api/Cliente/{id}");
            response.EnsureSuccessStatusCode();
        }
    }

}
