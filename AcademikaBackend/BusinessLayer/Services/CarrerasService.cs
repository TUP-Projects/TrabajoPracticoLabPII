using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
