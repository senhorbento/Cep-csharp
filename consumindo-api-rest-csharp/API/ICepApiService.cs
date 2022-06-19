using Refit;
using System.Threading.Tasks;

namespace consumindo_api_rest_csharp.API
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<EntidadeCep> GetAddressAsync(string cep);
    }
}
