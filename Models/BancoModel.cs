using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Models
{
    public class BancoModel
    {
        [JsonPropertyName("ispd")]
        public string? Ispb{ get;set;}

        [JsonPropertyName("name")]
        public string? Name{ get;set;}

        [JsonPropertyName("code")]
        public string? Code{ get;set;}

        [JsonPropertyName("FullName")]
        public string? FullName{ get;set;}

        
    }
}