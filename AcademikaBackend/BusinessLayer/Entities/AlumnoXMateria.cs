using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    public class AlumnoXMateria
    {
        public int Id_Alumno_Materia { get; set; }
        public Alumno Alumno { get; set; }
        public Materia Materia { get; set; }
        public Condicion Condicion { get; set; }
        public int Anio_Cursado { get; set; }
    }
}
