using AcademikaBackend.BusinessLayer.Entities;
using System.Collections.Generic;

namespace AcademikaBackend.DataLayer.Dao
{
    public interface ICursosDao
    {
        int ObtenerProxId(string tabla); 
        List<Curso> GetCursos(List<string> lst);
        List<Curso> GetCursos();
        bool CreateCurso(Curso oCurso);
        bool DeleteCurso(int id);
        Curso GetCursoById(int id);
        bool UpdateCurso(Curso curso);
    }
}
