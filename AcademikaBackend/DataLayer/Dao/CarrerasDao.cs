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
    public class CarrerasDao : ICarrerasDao
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
            lst = lst.Where(x => x.Estado == Estado.Habilitado.ToString()).ToList();
            return lst;
        }

        public bool CreateCarrera(Carrera oCarrera)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@carrera", DbType.String, oCarrera.NombreCarrera));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@duracion", DbType.Int32, oCarrera.Duracion));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@estado", DbType.Int32, (int)Estado.Habilitado));
            int result = (int)helper.EjecutarSql("SP_ALTA_CARRERA", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");
            return result != 0;
        }

        public bool DeleteCarrera(int id)
        {
            SqlCommand cmd = new SqlCommand();
            string sql = $"UPDATE CARRERAS SET estado = 0 WHERE id_carrera = {id}";
            int result = (int)helper.EjecutarSql(sql, cmd, CommandType.Text, null, "NonQuery");
            return result != 0;
        }

        public Carrera GetCarreraById(int id)
        {
            Carrera carrera = new();
            SqlCommand cmd = new();
            string sql = $"SELECT * FROM CARRERAS WHERE id_carrera = {id}";
            DataTable table = helper.ConsultaSQLNonSP(cmd, sql);

            foreach (DataRow row in table.Rows)
            {
                carrera = ObjectMapping(row);
            }

            return carrera;
        }

        private Carrera ObjectMapping(DataRow row)
        {
            Carrera carrera = new Carrera
            {
                Id_Carrera = Convert.ToInt32(row[0].ToString()),
                NombreCarrera = row[1].ToString(),
                Estado = ((Estado)Convert.ToInt32(row[2])).ToString(),
                Duracion = Convert.ToString(row[3])
            };
            return carrera;
        }

        public bool UpdateCarrera(Carrera carrera)
        {
            SqlCommand cmd = new SqlCommand();
            string exist = $"SELECT * FROM CARRERAS WHERE carrera = '{carrera.NombreCarrera}'";
            DataTable table = helper.ConsultaSQLNonSP(cmd, exist);
            if (table.Rows.Count == 1)
                return false;
            string sql = $"UPDATE CARRERAS SET carrera = '{carrera.NombreCarrera}', duracion = '{carrera.Duracion}' WHERE id_carrera = '{carrera.Id_Carrera}'";
            int result = (int)helper.EjecutarSql(sql, cmd, CommandType.Text, null, "NonQuery");
            return result != 0;
        }
    }
}
