using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Models
{
    public class BancoModel
    {
        [JsonPropertyName("ispd")]
        public string? Ispb{ get;set;}

        [JsonPropertyName("name")]
        public string? NameAbreviado{ get;set;}

        [JsonPropertyName("code")]
        public int? CodigoBanco{ get;set;}

        [JsonPropertyName("FullName")]
        public string? NomeCompleto{ get;set;}

        
    }
}