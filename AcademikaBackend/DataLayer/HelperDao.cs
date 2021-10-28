﻿using AcademikaBackend.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.DataLayer
{
    class HelperDao
    {
        private static HelperDao instance;
        private string connectionString;

        private HelperDao()
        {
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public static HelperDao GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDao();
            }
            return instance;
        }

        public DataTable ConsultaSQL(string storeName)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

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
                tabla = null;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return tabla;
        }


        //public bool EjecutarInsert(Alumno alumno, string spMaestro, string spDetalle)
        //{
        //    bool ok = true;

        //    SqlConnection connection = new SqlConnection(connectionString);
        //    SqlTransaction transaction = null;
        //    try
        //    {
        //        connection.Open();
        //        transaction = connection.BeginTransaction();
        //        //Se inserta Receta
        //        SqlCommand cmdMaestro = new SqlCommand(spMaestro, connection, transaction);
        //        cmdMaestro.CommandType = CommandType.StoredProcedure;

        //        cmdMaestro.Parameters.AddWithValue("@id_receta", alumno.RecetaNro);
        //        cmdMaestro.Parameters.AddWithValue("@tipo_receta", alumno.TipoDeReceta);
        //        cmdMaestro.Parameters.AddWithValue("@nombre", alumno.Nombre);
        //        if (alumno.Cheff != null)
        //            cmdMaestro.Parameters.AddWithValue("@cheff", alumno.Cheff);
        //        else
        //            cmdMaestro.Parameters.AddWithValue("@cheff", DBNull.Value);

        //        cmdMaestro.ExecuteNonQuery();

        //        //Se inserta Detalle Receta 
        //        foreach (DetalleReceta detalle in receta.Detalles)
        //        {
        //            SqlCommand cmdDetalle = new SqlCommand(spDetalle, connection, transaction);
        //            cmdDetalle.CommandType = CommandType.StoredProcedure;
        //            cmdDetalle.Parameters.AddWithValue("@id_receta", receta.RecetaNro);
        //            cmdDetalle.Parameters.AddWithValue("@id_ingrediente", detalle.Ingrediente.IdIngrediente);
        //            cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);

        //            cmdDetalle.ExecuteNonQuery();
        //        }

        //        transaction.Commit();
        //    }
        //    catch (Exception)
        //    {
        //        transaction.Rollback();
        //        ok = false;

        //    }
        //    finally
        //    {
        //        if (connection.State == ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //    return ok;
        //}

        public int EjecutarSQLConValorOUT(string nombreSP, string nombreParametro)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter();
            int val;
            try
            {
                cnn.Open();
                // Command Type para el Tipo de COmando que quiero ejecutar
                // cmd.CommandText = CommandType.Text;  ejecutamos sql como texto plano
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;
                param.ParameterName = nombreParametro;
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(param);
                cmd.ExecuteScalar();
                val = (int)param.Value;

            }
            catch (SqlException)
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
    }
}