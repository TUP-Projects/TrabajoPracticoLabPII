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

        bool ActualizaDatosMateriasxCarrera(List<MateriasXCarrera> lstmxc, List<DocentesXMateria> dxm, List<Curso> cursos);

        bool BajaCursoMateriaDocente(DocentesXMateria dxm);

        DataTable CargaDgvEntidad(string tabla);

        DataTable Consulta_PlanEstudios(int idCarrera);

        DataTable ConsultaMateriasCarrera(int idcarrera, int idmateria);

        bool InsertaMateriaCarrera(MateriasXCarrera oMateriasxCarrera);
        bool BajaMateriaCarrera(int idMateriaCarrera);

        public bool ActualizaMateriasxCarrera(MateriasXCarrera oMateriasxCarrera);
        bool InsertaMateria(Materia oMateria);
        bool RegistrarBajaMateria(int id);

        Materia ConsultarMateriaById(int id);
        bool ActualizarMateria(Materia materia);
    }
}
