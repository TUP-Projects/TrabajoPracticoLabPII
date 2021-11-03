using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    public class MateriasXCurso
    {
        public int Id_Materias_x_Curso { get; set; }

        public Materia Materia { get; set; }

        public Curso Curso { get; set; }

        public MateriasXCurso()
        {
            Materia = new Materia();
            Curso = new Curso();
        }
    }
}
