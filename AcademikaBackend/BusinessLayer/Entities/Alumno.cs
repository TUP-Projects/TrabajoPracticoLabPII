using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Num_Doc { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public bool Trabaja { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public EstadoCivil EstadoCivil { get; set; }
        public SituacionHabitacional SituacionHabitacional { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public TipoTrabajo TipoTrabajo { get; set; }
        public Barrio Barrio { get; set; }
        
    }
}
