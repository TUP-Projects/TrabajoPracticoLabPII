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

        public MateriasXCarrera Mxcar { get; set; }

        public string Cargo { get; set; }

        public Curso Curso { get; set; }
        public DocentesXMateria(Docente docente, MateriasXCarrera mxcar, string cargo, Curso curso) {

            this.Docente = docente;
            this.Curso = curso;
            this.Mxcar = mxcar;         
            this.Cargo = cargo;
        
        }
        public DocentesXMateria()
        {
            Docente = new Docente();
            Mxcar = new MateriasXCarrera();
            Curso = new Curso();
        }
    }
}
