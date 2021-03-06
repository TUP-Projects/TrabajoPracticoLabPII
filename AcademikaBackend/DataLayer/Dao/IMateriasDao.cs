using AcademikaBackend.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.DataLayer.Dao
{
    public interface IMateriasDao
    {
        int ObtenerProxId(string tabla); 
        
        DataTable ConsultaMateria(int id_materia);
        bool InsertaMateria(Materia materia, MateriasXCarrera mxc, List<DocentesXMateria> dxm);

        DataTable CargaCombos(string tabla);
        List<Materia> GetMaterias();
        bool ActualizaDatosMateriasxCarrera(List<MateriasXCarrera> lstmxc, List<DocentesXMateria> dxm, List<Curso> cursos);

        bool BajaCursoMateriaDocente(DocentesXMateria dxm);

        DataTable PlandeEstudios(int idCarrera);

        DataTable ConsultaMateriasCarrera(int idcarrera, int idmateria);

        public bool InsertaMateriaCarrera(MateriasXCarrera oMateriasXCarrera);

        public bool BajaMateriaCarrera(int idmateriacarrera);
        bool ActualizaMateriasxCarrera(MateriasXCarrera oMateriasxCarrera);
        bool InsertaMateria(Materia oMateria);
        bool DeleteMateria(int id);
        Materia GetMateriaById(int id);
        bool UpdateMateria(Materia materia);
        DataTable GetCondiciones(string filtro);
        DataTable GetCondiciones(Dictionary<string, object> lst);
        DataTable GetAlumnosSinCursar(int year);
        DataTable GetAlumnosSinAprobar(int year);
        DataTable GetAlumnosSinAprobar(Dictionary<string, object> lst);
    }
}
