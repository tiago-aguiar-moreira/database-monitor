using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseMonitor.WebAPI.Entidade;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DatabaseMonitor.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonitoriaController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        public MonitoriaController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Monitoria), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Consultar(int id)
        {
            return new OkObjectResult(new List<Monitoria>());
        }

        [HttpGet]
        [ProducesResponseType(typeof(IList<Monitoria>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Listar([FromQuery(Name = "ativo")] int ativo)
        {
            return new OkObjectResult(new List<Monitoria>());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Criar([FromBody] Monitoria monitoria)
        {
            return new OkObjectResult(new List<Monitoria>());
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Atualizar([FromBody] Monitoria monitoria)
        {
            return new OkObjectResult(new List<Monitoria>());
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult AtualizarAtributo([FromBody] Monitoria monitoria)
        {
            return new OkObjectResult(new List<Monitoria>());
        }
    }
}