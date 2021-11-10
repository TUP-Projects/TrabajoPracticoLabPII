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

        public object ConsultarCursos(List<string> lst)
        {
            return CursosDao.GetCursos(lst);
        }

        public bool CrearCurso(Curso oCurso)
        {
            return CursosDao.CreateCurso(oCurso);
        }

        public int ObtenerProxId(string tabla)
        {
            return CursosDao.ObtenerProxId(tabla);
        }

        public bool RegistrarBajaCurso(int id)
        {
            return CursosDao.DeleteCurso(id);
        }
    }
}
