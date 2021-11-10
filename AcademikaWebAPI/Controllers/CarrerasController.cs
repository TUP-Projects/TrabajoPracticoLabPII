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
    public class CarrerasController : Controller
    {
        private ICarrerasService _carrerasService;

        public CarrerasController()
        {
            _carrerasService = new ServiceFactoryImp().CrearServiceCarreras();
        }

        [HttpGet("Consulta")]
        public IActionResult GetMateriasDetalle()
        {
            return Ok(JsonConvert.SerializeObject(_carrerasService.ConsultarCarreras()));
        }

        // Añadir Carrera
        [HttpPost]
        public IActionResult PostCarrera(Carrera oCarrera)
        {
            if (oCarrera is null)
            {
                return BadRequest();
            }

            return Ok(_carrerasService.CrearCarrera(oCarrera));
        }
    }
}
