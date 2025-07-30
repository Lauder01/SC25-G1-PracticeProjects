using Microsoft.AspNetCore.Mvc;

namespace WebAPIRandomNumberGeneratorProject.Controllers
{
    [ApiController]
    [Route("api/codigo")]
    public class CodigoController(ICodigoGenerador codigoGenerador) : ControllerBase
    {
        private readonly ICodigoGenerador _codigoGenerador = codigoGenerador;

        [HttpGet("{prefijo}")]
        public IActionResult GetCodigo(string prefijo)
        {
            var codigo = _codigoGenerador.GenerarCodigo(prefijo);
            return Ok(new { CodigoGenerado = codigo });
        }
    }
}
