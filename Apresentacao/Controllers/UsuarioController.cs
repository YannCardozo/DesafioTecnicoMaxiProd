using Microsoft.AspNetCore.Mvc;

namespace Apresentacao.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        
        [HttpGet("ObterOK")]
        public IActionResult TesteInicial()
        {
            return Ok("OK");
        }
    }
}
