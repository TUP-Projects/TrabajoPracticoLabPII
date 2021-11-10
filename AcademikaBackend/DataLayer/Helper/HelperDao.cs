using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace AcademikaBackend.DataLayer.Helper
{
    public class HelperDao
    {
        private static HelperDao instance;
        private string connectionString;

        private HelperDao()
        {
            connectionString = ConnectionStrings.Cristian.ToString();
        }

        public static HelperDao GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDao();
            }
            return instance;
        }

        public DataTable ConsultaSQL(SqlCommand cmd, string storeName, List<DbParameter> ListaParametros = null)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            
            DataTable tabla = new DataTable();
            
            if (ListaParametros != null)
            {
                foreach (DbParameter parameter in ListaParametros)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                tabla.Load(cmd.ExecuteReader());

        }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return tabla;
        }


        
        public int EjecutarSQLConValorOUT(SqlCommand cmd, string nombreSP, List<DbParameter> ListaParametros = null)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlParameter param = new SqlParameter();
            int val;
            try
            {
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;

                if (ListaParametros != null)
                {
                    foreach (DbParameter parameter in ListaParametros)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                cmd.ExecuteScalar();
                val = (int)param.Value;

            }
            catch (SqlException ex)
            {
                val = 0;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return val;
        }

        public object EjecutarSql(string Query, SqlCommand cmd, CommandType TipoDeComando, List<DbParameter> ListaParametros = null, string TipoEjecucion = "")
        {
            SqlConnection cnn = new SqlConnection(instance.connectionString);
            cmd.CommandType = TipoDeComando;
            cmd.CommandText = Query;
            int RetVal = 0;
            if(ListaParametros != null)
            {
                foreach (DbParameter parameter in ListaParametros)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                switch (TipoEjecucion)
                {
                    case "Scalar":
                        RetVal = (int)cmd.ExecuteScalar();
                        break;
                    case "NonQuery":
                        RetVal = cmd.ExecuteNonQuery();
                        break;
                 }
                cmd.Dispose();
                cnn.Close();
                cnn.Dispose();
            }
            catch (Exception)
            {
                RetVal = 0;
            }

            return (int)RetVal;
        }

        public static DbParameter CrearParametro(SqlCommand MyCommand, string DbParameterName, DbType DbCommandType, object ParameterValue = null, ParameterDirection parameterDirection = ParameterDirection.Input)
        {
       
            SqlParameter MyParameter = MyCommand.CreateParameter();
            MyParameter.ParameterName = DbParameterName;
            MyParameter.DbType = DbCommandType;
            MyParameter.Value = ParameterValue;
            MyParameter.Direction = parameterDirection;


            return MyParameter;
        }

        public bool AltaMaterias(Materia materia, MateriasXCarrera mxc, List<DocentesXMateria> dxm)
        {
            bool ok = true;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaction = null;
            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();
                

                List<DbParameter> sqlParams = new List<DbParameter>();
                sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_materia", DbType.String, materia.Id_Materia));
                sqlParams.Add(HelperDao.CrearParametro(cmd, "@carga_horaria", DbType.Int32, mxc.CargaHoraria));
                sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_carrera", DbType.Int32, mxc.Carrera.Id_Carrera));
                sqlParams.Add(HelperDao.CrearParametro(cmd, "@cuatrimestre", DbType.Int32, mxc.Cuatrimestre));
                sqlParams.Add(HelperDao.CrearParametro(cmd, "@anio_dictado", DbType.Int32, mxc.AnioDictado));
                sqlParams.Add(HelperDao.CrearParametro(cmd, "@dictado", DbType.String, mxc.Dictado));


                foreach (DocentesXMateria item in dxm) {

                    if (item.Cargo == "Jefe")
                    {
                        sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_jefe", DbType.Int32, item.Docente.Id_Docente));
                        sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_curso", DbType.Int32, item.Curso.Id_Curso));
                    }
                    else if (item.Cargo == "Adjunto")
                        sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_prof_adj", DbType.Int32, item.Docente.Id_Docente));
                    else if (item.Cargo == "Ayudante")
                        sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_ayud", DbType.Int32, item.Docente.Id_Docente));
                }
                EjecutarSql("SP_ALTA_MATERIA_CARRERA_CURSO", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");

                transaction.Commit();
        }
            catch (Exception)
            {
                transaction.Rollback();
                ok = false;

            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return ok;
        }

    }
}