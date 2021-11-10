using AcademikaBackend.BusinessLayer.Entities;
using System.Collections.Generic;

namespace AcademikaBackend.BusinessLayer.Services
{
    public interface ICursosService
    {
        int ObtenerProxId(string tabla);
        public List<Curso> ConsultarCursos();
        bool RegistrarBajaCurso(int id);
        object ConsultarCursos(List<string> lst);
        bool CrearCurso(Curso oCurso);
    }
}
