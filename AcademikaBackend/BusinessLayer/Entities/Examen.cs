using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    public class Examen
    {
        public int Id_Examen { get; set; }
        public int Id_Tipo_Examen { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Turno { get; set; }
        public int Id_Materia { get; set; }
        public int Legajo { get; set; }
        public int Nota { get; set; }
    }
}
