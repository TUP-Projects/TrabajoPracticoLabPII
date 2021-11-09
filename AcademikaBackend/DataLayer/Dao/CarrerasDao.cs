using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace AcademikaBackend.DataLayer.Dao
{
    public class CarrerasDao : ICarrerasDao
    {
        HelperDao helper = HelperDao.GetInstance();

        public int ObtenerProxId(string tabla)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@tabla", DbType.String, tabla));
            int prox_id = (int)HelperDao.EjecutarSql("SP_OBTENER_PROX_ID", cmd, CommandType.StoredProcedure, sqlParams, "Scalar");            
            return prox_id;
        }

        public List<Carrera> GetCarreras()
        {
            List<Carrera> lst = new();
            SqlCommand cmd = new();
            DataTable table = helper.ConsultaSQL(cmd, "SP_CONSULTAR_CARRERAS");

            foreach (DataRow row in table.Rows)
            {
                Carrera oCarrera = new Carrera
                {
                    Id_Carrera = Convert.ToInt32(row[0].ToString()),
                    NombreCarrera = row[1].ToString(),
                    Estado = ((Estado)Convert.ToInt32(row[2])).ToString(),
                    Duracion = Convert.ToInt32(row[3]) + " Año/s"
                };
                lst.Add(oCarrera);
            }

            return lst;
        }
    }
}
