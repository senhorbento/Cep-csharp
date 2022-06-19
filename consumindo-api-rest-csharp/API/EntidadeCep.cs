using Newtonsoft.Json;

namespace consumindo_api_rest_csharp.API
{
    public class EntidadeCep
    {
        [JsonProperty("cep")]
        public string cep               { get; set; }
        [JsonProperty("logradouro")]
        public string logradouro        { get; set; }
        [JsonProperty("complemento")]
        public string complemento       { get; set; }
        [JsonProperty("bairro")]
        public string bairro            { get; set; }
        [JsonProperty("localidade")]
        public string localidade        { get; set; }
        [JsonProperty("uf")]
        public string uf                { get; set; }
        [JsonProperty("ibge")]
        public string ibge              { get; set; }
        [JsonProperty("gia")]
        public string gia               { get; set; }
        [JsonProperty("ddd")]
        public string ddd               { get; set; }
        [JsonProperty("siafi")]
        public string siafi             { get; set; }
        [JsonProperty("erro")]
        public string erro { get; set; }
    }
}
