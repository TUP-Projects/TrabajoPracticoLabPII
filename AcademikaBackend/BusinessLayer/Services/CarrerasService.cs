using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer.Dao;
using System.Collections.Generic;

namespace AcademikaBackend.BusinessLayer.Services
{
    public class CarrerasService : ICarrerasService
    {
        private ICarrerasDao CarreraDao;

        public CarrerasService()
        {
            CarreraDao = new CarrerasDao();
        }

        public List<Carrera> ConsultarCarreras()
        {
            return CarreraDao.GetCarreras();
        }

        public int ObtenerProxId(string tabla)
        {
            return CarreraDao.ObtenerProxId(tabla);
        }

        public bool CrearCarrera(Carrera oCarrera)
        {
            return CarreraDao.CreateCarrera(oCarrera);
        }

        public bool RegistrarBajaCarrera(int id)
        {
            return CarreraDao.DeleteCarrera(id);
        }

        public Carrera ConsultarCarreraById(int id)
        {
            return CarreraDao.GetCarreraById(id);
        }

        public bool ActualizarCarrera(Carrera carrera)
        {
            return CarreraDao.UpdateCarrera(carrera);
        }
    }
}
