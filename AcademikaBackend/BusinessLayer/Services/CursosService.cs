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
