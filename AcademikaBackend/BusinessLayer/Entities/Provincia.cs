using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    public class Provincia
    {
        public int Id_provincia { get; set; }
        public string Nom_provincia { get; set; }
        public Pais Pais { get; set; }

    }
}
