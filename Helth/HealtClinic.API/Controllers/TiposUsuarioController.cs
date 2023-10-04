
using HealtClinic.API.Domain;
using HealtClinic.API.Interface;
using HealtClinic.API.Repository;
using Microsoft.AspNetCore.Mvc;


namespace webapi.HealthClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository tipoUsuarioRepository;
        private TiposUsuarioRepository _TiposUsuarioRepository;

        public TiposUsuarioController()
        {
            _TiposUsuarioRepository = new TiposUsuarioRepository();
        }
        [HttpPost]

        public IActionResult Post(TipoUsuario tiposUsuario)
        {
            try
            {
                _TiposUsuarioRepository.Cadastrar(tiposUsuario);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
