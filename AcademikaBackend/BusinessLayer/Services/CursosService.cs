using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer.Dao;
using System.Collections.Generic;

namespace AcademikaBackend.BusinessLayer.Services
{
    public class CursosService : ICursosService
    {
        private ICursosDao CursosDao;

        public CursosService()
        {
            CursosDao = new CursosDao();
        }

        public List<Curso> ConsultarCursos()
        {
            return CursosDao.GetCursos();
        }

        public int ObtenerProxId(string tabla)
        {
            return CursosDao.ObtenerProxId(tabla);
        }
    }
}
