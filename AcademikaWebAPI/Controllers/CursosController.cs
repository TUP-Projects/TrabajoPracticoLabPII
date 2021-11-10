using AcademikaBackend.BusinessLayer.Entities;
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
    [ApiController]
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

        // Borrar curso por Id
        [HttpDelete("{id}")]
        public IActionResult DeleteCurso(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(_cursosService.RegistrarBajaCurso(id));
        }

        // Buscar cursos por parámetros
        [HttpPost("consultar")]
        public IActionResult GetCursos(List<string> lst)
        {
            if (lst == null || lst.Count == 0)
                return BadRequest("Se requiere una lista de parámetros!");

            return Ok(_cursosService.ConsultarCursos(lst));
        }
        
        // Añadir Curso
        [HttpPost]
        public IActionResult PostCurso(Curso oCurso)
        {
            if (oCurso is null)
            {
                return BadRequest();
            }

            return Ok(_cursosService.CrearCurso(oCurso));
        }
    }
}
