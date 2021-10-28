using AcademikaBackend.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Services
{
    public interface IAlumnosService
    {
        public bool GuardarAlumno(Alumno oAlumno);
    }
}
