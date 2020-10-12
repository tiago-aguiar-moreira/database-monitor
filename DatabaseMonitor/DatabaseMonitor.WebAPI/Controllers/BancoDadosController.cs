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
    [ApiController]
    [Route("api/[controller]")]
    public class BancoDadosController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        public BancoDadosController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IList<BancoDados>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult ListarBancoDados()
        {
            return new OkObjectResult(new List<BancoDados>());
        }

        [HttpGet("{nomeBancoDados}/procedure")]
        [ProducesResponseType(typeof(IList<BancoDados>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult ListarProcedure(string nomeBancoDados)
        {
            return new OkObjectResult(new List<BancoDados>());
        }

        [HttpGet("{nomeBancoDados}/procedure/{nomeProc}")]
        [ProducesResponseType(typeof(BancoDados), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult ConsultarProcedure(string nomeBancoDados, string nomeProc)
        {
            return new OkObjectResult(new BancoDados());
        }
    }
}