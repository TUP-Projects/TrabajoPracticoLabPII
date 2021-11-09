using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Services
{
    public class MateriasService: IMateriasService
    {
        private IMateriasDao MateriasDao;

        public MateriasService()
        {
            MateriasDao = new MateriasDao();
        }

        public List<Materia> ConsultarMaterias()
        {
            return MateriasDao.GetMaterias();
        }

        public bool ActualizaDatosMateriasxCarrera(MateriasXCarrera mxc)
        {
            return MateriasDao.ActualizaDatosMateriasxCarrera(mxc);
        }

        public List<EntidadGenerica> CargaCombos(string tabla, int estado)
        {
            List<EntidadGenerica> lst = new List<EntidadGenerica>();
            foreach (DataRow row in MateriasDao.CargaCombos(tabla, estado).Rows) {

                EntidadGenerica oEntidadGen = new EntidadGenerica();
                oEntidadGen.ID = Convert.ToInt32(row["ID"].ToString());
                oEntidadGen.Descripcion = row["Descripcion"].ToString();

                lst.Add(oEntidadGen);
            }

            return lst;
        }

        public DataTable ConsultaMateria(int id_materia)
        {
            return MateriasDao.ConsultaMateria(id_materia);
        }

        public bool BajaCursoMateriaDocente(DocentesXMateria dxm)
        {
            return MateriasDao.BajaCursoMateriaDocente(dxm);
        }

        public bool InsertarMateria(Materia materia, MateriasXCarrera mxc, List<DocentesXMateria> dxm)
        {
            return MateriasDao.InsertaMateria(materia, mxc, dxm);
        }

        public int ObtenerProxId(string tabla)
        {

            return MateriasDao.ObtenerProxId(tabla);
        }

        public DataTable CargaDgvEntidad(string tabla, int estado)
        {
            return MateriasDao.CargaCombos(tabla, estado);
        }
    }
}
