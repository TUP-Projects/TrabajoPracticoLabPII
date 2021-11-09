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
    }
}
