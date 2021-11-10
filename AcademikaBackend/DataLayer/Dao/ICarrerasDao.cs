using AcademikaBackend.BusinessLayer.Entities;
using System.Collections.Generic;

namespace AcademikaBackend.DataLayer.Dao
{
    public interface ICarrerasDao
    {
        int ObtenerProxId(string tabla); 
        List<Carrera> GetCarreras();
        bool CreateCarrera(Carrera oCarrera);
    }
}
