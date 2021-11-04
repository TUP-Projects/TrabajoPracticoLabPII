using AcademikaBackend.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.DataLayer
{
    public class MateriasDao : IMateriasDao
    {
        HelperDao helper = HelperDao.GetInstance();

        public DataTable ConsultaMateria(int id_materia)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_materia", DbType.Int32, id_materia));
            DataTable table = helper.ConsultaSQL(cmd, "SP_CONSULTA_MATERIAS", sqlParams);

            return table;
        }

        public bool InsertaMateria(Materia materia, MateriasXCarrera mxc, MateriasXCurso mxcur, List<DocentesXMateria> dxm)
        {
            bool trx = helper.AltaMaterias(materia, mxc, mxcur, dxm);
           
            return trx;
        }

        public int ObtenerProxId(string tabla)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@tabla", DbType.String, tabla));
            int prox_id = (int)HelperDao.EjecutarSql("SP_OBTENER_PROX_ID", cmd, CommandType.StoredProcedure, sqlParams, "Scalar");            
            return prox_id;
        }

        public bool ActualizaDatosMateriasxCarrera(MateriasXCarrera mxc)
        {
            
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_materia_x_carrera ", DbType.Int32, mxc.Id_Materias_x_Carrera));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@dictado", DbType.String, mxc.Dictado));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@cuatrimestre", DbType.String, mxc.Cuatrimestre));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@anio_dictado", DbType.Int32, mxc.AnioDictado));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@carga_horaria", DbType.Int32, mxc.CargaHoraria));

            int retVal = (int)HelperDao.EjecutarSql("SP_ACTUALIZA_MATERIASxCARRERA", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");
            //if (retVal > 0)
            //    return true;
            //else
            //    return false;

            return retVal > 0 ? true : false;
        }
        public DataTable CargaCombos(string tabla) {

            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();


            sqlParams.Add(HelperDao.CrearParametro(cmd, "@tabla", DbType.String, tabla));
            DataTable table = helper.ConsultaSQL(cmd, "SP_CONSULTA_ENTIDAD", sqlParams);

            return table;
        }

        public bool EliminaDocxCarrera(DocentesXMateria dxm)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_docente", DbType.Int32, dxm.Docente.Id_Docente));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_materia_curso", DbType.Int32, dxm.Mxcur.Id_Materias_x_Curso));
          
            int retVal = (int)HelperDao.EjecutarSql("SP_DELETE_DOCENTESxMATERIA", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");
            
            return retVal > 0;
        }

        public List<Materia> GetMaterias()
        {
            List<Materia> lst = new();
            SqlCommand cmd = new();
            DataTable table = helper.ConsultaSQL(cmd, "SP_CONSULTAR_MATERIAS");

            foreach (DataRow row in table.Rows)
            {
                Materia oMateria = new Materia();
                oMateria.Id_Materia = Convert.ToInt32(row["id_materia"].ToString());
                oMateria.NombreMateria = row["materia"].ToString();

                lst.Add(oMateria);
            }

            return lst;
        }
    }
}
