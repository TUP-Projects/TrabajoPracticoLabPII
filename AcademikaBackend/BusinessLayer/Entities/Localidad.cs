using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    public class Localidad
    {
        public int Id_Localidad { get; set; }
        public string Nom_Localidad { get; set; }
        public Provincia Provincia { get; set; }
    }
}
