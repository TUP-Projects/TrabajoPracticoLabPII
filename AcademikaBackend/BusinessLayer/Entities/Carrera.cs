using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    public class Carrera
    {
        public int Id_Carrera { get; set; }
        public string NombreCarrera { get; set; }
        public int Duracion { get; set; }
        public string Estado { get; set; }
    }
}
