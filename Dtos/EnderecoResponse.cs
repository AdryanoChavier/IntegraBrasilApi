using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Dtos
{
    public class EnderecoResponse
    {
        public string? Cep { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Região { get; set; }
        public string? Rua { get; set; }

        [JsonIgnore] //Pra não  mostrar pro usuário
        public string? Servico { get; set; }
    }
}