using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer.Dao;
using System;
using System.Collections.Generic;
using System.Data;

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

        public bool ActualizaDatosMateriasxCarrera(List<MateriasXCarrera> lstmxc, List<DocentesXMateria> dxm, List<Curso> cursos)
        {
            return MateriasDao.ActualizaDatosMateriasxCarrera(lstmxc, dxm, cursos);
        }

        public List<EntidadGenerica> CargaCombos(string tabla)
        {
            List<EntidadGenerica> lst = new List<EntidadGenerica>();
            foreach (DataRow row in MateriasDao.CargaCombos(tabla).Rows) {

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

        public DataTable CargaDgvEntidad(string tabla)
        {
            return MateriasDao.CargaCombos(tabla);
        }

        public DataTable Consulta_PlanEstudios() {

            return MateriasDao.PlandeEstudios();
        }
    }
}
