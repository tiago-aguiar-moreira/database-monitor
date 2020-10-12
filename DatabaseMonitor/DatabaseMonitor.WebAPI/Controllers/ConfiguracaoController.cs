using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseMonitor.WebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DatabaseMonitor.WebAPI.Controllers
{
    public class ConfiguracaoController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        public ConfiguracaoController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Configuracao), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Consultar(int id)
        {
            return new OkObjectResult(new List<Configuracao>());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Criar([FromBody] Configuracao configuracao)
        {
            return new OkObjectResult(new List<Configuracao>());
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Atualizar([FromBody] Configuracao configuracao)
        {
            return new OkObjectResult(new List<Configuracao>());
        }
    }
}