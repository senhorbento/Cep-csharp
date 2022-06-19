using Refit;
using System;
using System.Threading.Tasks;

namespace consumindo_api_rest_csharp.API
{
    public class RequestApi
    {
        public EntidadeCep address = new EntidadeCep();
        public async Task Request(string cep)
        {
            try
            {
                var cepCliente = RestService.For<ICepApiService>("http://viacep.com.br");
                address = await cepCliente.GetAddressAsync(cep);

            }
            catch(Exception e)
            {
                Console.WriteLine("Erro" + e);
            }
        }

        public EntidadeCep GetEntidade(string cep)
        {
            _ = Request(cep);
            return address;
        }
    }
}
