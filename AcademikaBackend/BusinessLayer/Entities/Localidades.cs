using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    class Localidades
    {
        public int Id_Localidad { get; set; }
        public string Nom_Localidad { get; set; }

        public int Id_Provincia { get; set; }
    }
}
