using HealtClinic.API.Domain;
using HealtClinic.API.Interface;
using HealtClinic.API.Repository.webapi.event_.manha.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;




namespace webapi.HealthClinic.API.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        [Produces("application/json")]
        public class UsuarioController : ControllerBase
        {
            private IUsuarioRepository usuarioRepository;

            public UsuarioController()
            {
                usuarioRepository = new UsuarioRepository();
            }

            [HttpPost]
            public IActionResult Post(Usuario usuario)
            {
                try
                {
                    usuarioRepository.Cadastrar(usuario);
                    return StatusCode(201);

                }
                catch (Exception e)
                {

                    return BadRequest(e.Message);
                }

            }

        }
    }


