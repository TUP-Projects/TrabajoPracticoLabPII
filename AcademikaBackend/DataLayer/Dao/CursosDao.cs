using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

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
                Curso oCurso = new Curso
                {
                    Id_Curso = Convert.ToInt32(row[0].ToString()),
                    NombreCurso = row[1].ToString(),
                    Estado = ((Estado)Convert.ToInt32(row[2])).ToString(),
                };
                lst.Add(oCurso);
            }

            return lst;
        }
    }
}
