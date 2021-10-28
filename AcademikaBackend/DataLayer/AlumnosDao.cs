using AcademikaBackend.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.DataLayer
{
    public class AlumnosDao : IAlumnosDao
    {
        public bool Save(Alumno oAlumno)
        {
            //DataTable dt = HelperDao.GetInstance().ConsultaSQL("SP_INSERTAR_ALUMNO");
            //if (dt.Rows.Count > 0)
            //    return true;
            return true;
        }
    }
}
