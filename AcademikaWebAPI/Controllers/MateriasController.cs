using AcademikaBackend.BusinessLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademikaWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class MateriasController : Controller
    {
        private IMateriasService _materiasService;

        public MateriasController()
        {
            _materiasService = new ServiceFactoryImp().CrearServiceMaterias();
        }

        [HttpGet]
        public IActionResult GetAllMaterias()
        {
            return Ok(_materiasService.ConsultarMaterias());
        }
    }
}
