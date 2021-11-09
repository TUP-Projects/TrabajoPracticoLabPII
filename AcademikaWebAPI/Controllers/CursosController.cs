using AcademikaBackend.BusinessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademikaWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CursosController : Controller
    {
        private ICursosService _cursosService;

        public CursosController()
        {
            _cursosService = new ServiceFactoryImp().CrearServiceCursos();
        }

        [HttpGet("Consulta")]
        public IActionResult GetCursos()
        {
            return Ok(JsonConvert.SerializeObject(_cursosService.ConsultarCursos()));
        }
    }
}
