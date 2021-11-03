using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Entities
{
    public class DocentesXMateria
    {
        public Docente Docente { get; set; }

        public MateriasXCurso Mxcur { get; set; }

        public string Cargo { get; set; }

        public DocentesXMateria(Docente docente, MateriasXCurso mxcur, string cargo) {

            this.Docente = docente;
            this.Mxcur = mxcur;
            this.Cargo = cargo;
        
        }
        public DocentesXMateria()
        {
            Docente = new Docente();
            Mxcur = new MateriasXCurso();
        }
    }
}
