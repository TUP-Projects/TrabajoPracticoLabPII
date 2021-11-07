using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    public class MateriasXCarrera
    {
        public int Id_Materias_x_Carrera { get; set; }
        public Materia Materia { get; set; }
        public Carrera Carrera { get; set; }

        public int AnioDictado { get; set; }

        public int Cuatrimestre { get; set; }

        public int CargaHoraria { get; set; }
        public string Dictado { get; set; }

        public int Estado { get; set; }

        public MateriasXCarrera()
        {
            Materia = new Materia();
            Carrera = new Carrera();
        }
    }
}
