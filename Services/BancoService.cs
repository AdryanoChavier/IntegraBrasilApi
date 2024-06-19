using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilapi;

        public BancoService(IMapper mapper, IBrasilApi brasilapi)
        {
            _mapper = mapper;
            _brasilapi = brasilapi;
        }
        public async Task<ResponseGenerico<List<BancoResponse>>> BuscarTodosBancos()
        {
            var banco = await _brasilapi.BuscarTodosBancos();
            return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(banco);
        }

        public async Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco)
        {
          var codigo = await _brasilapi.BuscarBanco(codigoBanco);
          return _mapper.Map<ResponseGenerico<BancoResponse>>(codigo);

        }
    }
} 
