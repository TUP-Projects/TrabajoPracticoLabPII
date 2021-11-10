using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace AcademikaBackend.DataLayer.Dao
{
    public class CursosDao : ICursosDao
    {
        HelperDao helper = HelperDao.GetInstance();

        public int ObtenerProxId(string tabla)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@tabla", DbType.String, tabla));
            int prox_id = (int)helper.EjecutarSql("SP_OBTENER_PROX_ID", cmd, CommandType.StoredProcedure, sqlParams, "Scalar");            
            return prox_id;
        }

        public List<Curso> GetCursos()
        {
            List<Curso> lst = new();
            SqlCommand cmd = new();
            DataTable table = helper.ConsultaSQL(cmd, "SP_CONSULTAR_CURSOS");

            foreach (DataRow row in table.Rows)
            {
                lst.Add(ObjectMapping(row));
            }

            lst = lst.Where(x => x.Estado == Estado.Habilitado.ToString()).ToList();
            return lst;
        }

        public List<Curso> GetCursos(List<string> lst)
        {
            throw new NotImplementedException();
        }

        public bool CreateCurso(Curso oCurso)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@nombre_curso", DbType.String, oCurso.NombreCurso));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@estado", DbType.Int32, (int)Estado.Habilitado));
            int result = (int)helper.EjecutarSql("SP_ALTA_CURSO", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");
            return result != 0;
        }

        public bool DeleteCurso(int id)
        {
            SqlCommand cmd = new SqlCommand();
            string sql = $"UPDATE CURSOS SET estado = 0 WHERE id_curso = {id}";
            int result = (int)helper.EjecutarSql(sql, cmd, CommandType.Text, null, "NonQuery");
            return result != 0;
        }

        private Curso ObjectMapping(DataRow row)
        {
            Curso curso = new Curso();
            curso.Id_Curso = Convert.ToInt32(row[0]);
            curso.NombreCurso = row[1].ToString();
            curso.Estado = ((Estado)Convert.ToInt32(row[2])).ToString();
            return curso;
        }
    }
}
