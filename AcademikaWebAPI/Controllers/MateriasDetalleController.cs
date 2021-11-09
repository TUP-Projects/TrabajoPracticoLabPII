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
    public class MateriasDetalleController : Controller
    {
        private IMateriasService _materiasDetalleService;

        public MateriasDetalleController()
        {
            _materiasDetalleService = new ServiceFactoryImp().CrearServiceMaterias();
        }

        [HttpGet("{entidad}")]
        public IActionResult GetEntidad(string entidad, int estado)
        {
            if (String.IsNullOrEmpty(entidad))
                return BadRequest("La entidad no puede ser nula.");
            return Ok(_materiasDetalleService.CargaCombos(entidad, estado));
        }

        [HttpGet("Consulta/{idMateria}")]
        public IActionResult GetMateriasDetalle(int idMateria)
        {
            return Ok(JsonConvert.SerializeObject(_materiasDetalleService.ConsultaMateria(idMateria)));
        }

    }
}
