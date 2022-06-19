using Refit;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace consumindo_api_rest_csharp.API
{
    public class RequestApi
    {
        public async Task<EntidadeCep> Request(string cep)
        {
            EntidadeCep address = new EntidadeCep();
            try
            {
                var cepCliente = RestService.For<ICepApiService>("http://viacep.com.br");
                address = await cepCliente.GetAddressAsync(cep);
            }
            catch(Exception e)
            {
                address.erro = "true";
            }
            return address;
        }
    }
}
