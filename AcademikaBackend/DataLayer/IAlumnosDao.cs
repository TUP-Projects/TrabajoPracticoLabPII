using AcademikaBackend.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.DataLayer
{
    public interface IAlumnosDao
    {
        public bool Save(Alumno oAlumno);
    }
}
