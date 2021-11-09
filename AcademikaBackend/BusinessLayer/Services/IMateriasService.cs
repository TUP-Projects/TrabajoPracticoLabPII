using AcademikaBackend.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Services
{
    public interface IMateriasService
    {
        bool InsertarMateria(Materia materia, MateriasXCarrera mxc, List<DocentesXMateria> dxm);
        int ObtenerProxId(string tabla);

        DataTable ConsultaMateria(int id_materia);

        List<EntidadGenerica> CargaCombos(string tabla);

        public List<Materia> ConsultarMaterias();

        bool ActualizaDatosMateriasxCarrera(MateriasXCarrera mxc);

        bool BajaCursoMateriaDocente(DocentesXMateria dxm);

        DataTable CargaDgvEntidad(string tabla);


    }
}
