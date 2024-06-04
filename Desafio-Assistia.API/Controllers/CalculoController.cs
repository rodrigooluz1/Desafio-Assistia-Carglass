using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_Assistia.API.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_Assistia.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoController : Controller
    {
        private readonly ILogger<CalculoController> _logger;
        private readonly ICalculoService _calculoService;

        public CalculoController(ILogger<CalculoController> logger, ICalculoService calculoService)
        {
            _logger = logger;
            _calculoService = calculoService;
        }

        [HttpGet("divisores/{numero}", Name = "CalculaDivisores")]
        public async Task<ActionResult> CalculaDivisores([FromRoute] int numero)
        {
            var retorno = await _calculoService.CalculaDivisores(numero);
            _logger.LogInformation(retorno.message);
            return Ok(retorno);
        }

    }
}

