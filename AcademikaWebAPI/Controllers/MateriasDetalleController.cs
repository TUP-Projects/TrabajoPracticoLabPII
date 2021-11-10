﻿using AcademikaBackend.BusinessLayer.Services;
using AcademikaBackend.BusinessLayer.Entities;
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
        public IActionResult GetEntidad(string entidad)
        {
            if (String.IsNullOrEmpty(entidad))
                return BadRequest("La entidad no puede ser nula.");
            return Ok(_materiasDetalleService.CargaCombos(entidad));
        }

        [HttpGet("Consulta")]
        public IActionResult GetCursos()
        {
            return Ok(JsonConvert.SerializeObject(_materiasDetalleService.ConsultarMaterias()));
        }

        [HttpGet("Consulta/{idMateria}")]
        public IActionResult GetMateriasDetalle(int idMateria)
        {
            return Ok(JsonConvert.SerializeObject(_materiasDetalleService.ConsultaMateria(idMateria)));
        }
        [HttpGet("RelacionCarreras/{idcarrera}/{idmateria}")]
        public IActionResult GetMateriasCarrera(int idcarrera, int idmateria)
        {
            return Ok(JsonConvert.SerializeObject(_materiasDetalleService.ConsultaMateriasCarrera(idcarrera, idmateria)));
        }


        [HttpPost]
        public IActionResult PostMateriaCarrera(MateriasXCarrera oMateriaxCarrera)
        {
            if (oMateriaxCarrera is null)
            {
                return BadRequest();
            }

            return Ok(_materiasDetalleService.InsertaMateriaCarrera(oMateriaxCarrera));
        }
    }
}
