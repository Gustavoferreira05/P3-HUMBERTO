using Microsoft.AspNetCore.Mvc;
using Prova2Bim.Application.Interfaces;
using Prova2Bim.Dominio.Entidades;

namespace Prova2Bim.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogoController : ControllerBase
    {
        private readonly IJogoService _service;

        public JogoController(IJogoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult RegistrarJogo([FromBody] Jogo jogo)
        {
            _service.RegistrarJogo(jogo);
            return Ok();
        }

        [HttpGet]
        public IActionResult ListarTodosJogos()
        {
            return Ok(_service.ListarTodosJogos());
        }
    }
}
