using AcademikaBackend.BusinessLayer.Entities;
using System.Collections.Generic;

namespace AcademikaBackend.BusinessLayer.Services
{
    public interface ICarrerasService
    {
        int ObtenerProxId(string tabla);
        public List<Carrera> ConsultarCarreras();
        bool CrearCarrera(Carrera oCarrera);
    }
}
