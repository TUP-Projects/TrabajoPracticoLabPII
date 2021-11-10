using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcademikaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _loginService;

        public LoginController()
        {
            _loginService = new ServiceFactoryImp().CrearServiceLogin();
        }

        [HttpPost]
        public IActionResult Login(Usuario oUsuario)
        {
            if (oUsuario is null)
                return BadRequest("El usuario no puede ser nulo.");
            return Ok(_loginService.IniciarSesion(oUsuario));
        }

        //[HttpGet("Consulta/{idUsuario}")]
        //public IActionResult GetUsuario(int idUsuario)
        //{
        //    return Ok(JsonConvert.SerializeObject(_materiasDetalleService.ConsultaMateria(idMateria)));
        //}
    }
}
