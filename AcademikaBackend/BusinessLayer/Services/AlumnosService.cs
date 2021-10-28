using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Services
{
    public class AlumnosService: IAlumnosService
    {
        private IAlumnosDao AlumnosDao;

        public AlumnosService()
        {
            AlumnosDao = new AlumnosDao();
        }

        public bool GuardarAlumno(Alumno oAlumno)
        {
            return AlumnosDao.Save(oAlumno);
        }
    }
}
