using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    class Barrio
    {
        public int Id_Barrio { get; set; }
        public string  Nom_Barrio { get; set; }

        public int Id_Localidad { get; set; }
    }
}
