using AcademikaBackend.BusinessLayer.Entities;
using System.Collections.Generic;

namespace AcademikaBackend.DataLayer.Dao
{
    public interface ICursosDao
    {
        int ObtenerProxId(string tabla); 
        List<Curso> GetCursos();
    }
}
