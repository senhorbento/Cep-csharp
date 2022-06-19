using Refit;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace consumindo_api_rest_csharp.API
{
    public class RequestApi
    {
        public static async Task<EntidadeCep> Request(string cep)
        {
            EntidadeCep address = new EntidadeCep();
            try
            {
                var cepCliente = RestService.For<ICepApiService>("http://viacep.com.br");
                address = await cepCliente.GetAddressAsync(cep);
            }
            catch(Exception e)
            {
                Debug.WriteLine("Erro" + e);
                address.cep = "Cep não encontrado";
            }
            return address;
        }
    }
}
