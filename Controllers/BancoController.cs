using System.ComponentModel.DataAnnotations;
using System.Net;
using IntegraBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace IntegraBrasilApi.Controllers
{   
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {
        public readonly IBancoService _bancoService;
        public BancoController(IBancoService bancoService){
            _bancoService = bancoService;
        }

        [HttpGet("buscar/todos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarTodosBancos()
        {
            var response = await _bancoService.BuscarTodosBancos();
             if(response.CodigoHttp == HttpStatusCode.OK){
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp,response.ErroRetorno);
            }
        }


        [HttpGet("buscar/{codigoBanco}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> BuscarBanco([RegularExpression("^[0-9]*$")]string codigoBanco){
            var response = await _bancoService.BuscarBanco(codigoBanco);
            if(response.CodigoHttp == HttpStatusCode.OK){
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp,response.ErroRetorno);
            }
        }
    }
}

       
       
