using AcademikaBackend.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.DataLayer
{
    public interface IMateriasDao
    {
        int ObtenerProxId(string tabla); 
        
        DataTable ConsultaMateria(int id_materia);
        bool InsertaMateria(Materia materia, MateriasXCarrera mxc, MateriasXCurso mxcur, List<DocentesXMateria> dxm);

        DataTable CargaCombos(string tabla);
        List<Materia> GetMaterias();
        bool ActualizaDatosMateriasxCarrera(MateriasXCarrera mxc);

        bool EliminaDocxCarrera(DocentesXMateria dxm);
    }
}
