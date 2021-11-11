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
    public class MateriasDao : IMateriasDao
    {
        HelperDao helper = HelperDao.GetInstance();

        public DataTable ConsultaMateria(int id_materia)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_materia", DbType.Int32, id_materia));
            DataTable table = helper.ConsultaSQL(cmd, "SP_CONSULTA_MATERIAS_DETALLE", sqlParams);

            return table;
        }

        public bool InsertaMateria(Materia materia, MateriasXCarrera mxc,  List<DocentesXMateria> dxm)
        {
            bool trx = helper.AltaMaterias(materia, mxc, dxm);
           
            return trx;
        }

        public int ObtenerProxId(string tabla)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@tabla", DbType.String, tabla));
            int prox_id = (int)helper.EjecutarSql("SP_OBTENER_PROX_ID", cmd, CommandType.StoredProcedure, sqlParams, "Scalar");            
            return prox_id;
        }

        public bool ActualizaDatosMateriasxCarrera(List<MateriasXCarrera> lstmxc, List<DocentesXMateria> dxm, List<Curso> cursos)
        {
            
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_materia_x_carrera", DbType.Int32, lstmxc[0].Id_Materias_x_Carrera));
            
            
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_materia_nuevo", DbType.Int32, lstmxc[1].Materia.Id_Materia));
            
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_carrera_nuevo", DbType.Int32, lstmxc[1].Carrera.Id_Carrera));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_curso", DbType.Int32, cursos[0].Id_Curso));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_curso_nuevo", DbType.Int32, cursos[1].Id_Curso));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@dictado", DbType.String, lstmxc[1].Dictado));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@cuatrimestre", DbType.String, lstmxc[1].Cuatrimestre));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@anio_dictado", DbType.Int32, lstmxc[1].AnioDictado));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@carga_horaria", DbType.Int32, lstmxc[1].CargaHoraria));

            foreach (DocentesXMateria item in dxm)
            {

                if (item.Cargo == "Jefe")
                {
                    sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_jefe", DbType.Int32, item.Docente.Id_Docente));
                }
                else if (item.Cargo == "Adjunto")
                    sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_prof_adj", DbType.Int32, item.Docente.Id_Docente));
                else if (item.Cargo == "Ayudante")
                    sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_ayud", DbType.Int32, item.Docente.Id_Docente));
            }

            int retVal = (int)helper.EjecutarSql("SP_ACTUALIZA_MATERIASxCARRERAxCURSO", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");
            return retVal > 0;
        }

        public DataTable CargaCombos(string tabla) {

            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@tabla", DbType.String, tabla));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@estado", DbType.String, (int)Estado.Habilitado));
            DataTable table = helper.ConsultaSQL(cmd, "SP_CONSULTA_ENTIDAD", sqlParams);

            return table;
        }

        public bool BajaCursoMateriaDocente(DocentesXMateria dxm)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_curso", DbType.Int32, dxm.Curso.Id_Curso));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@id_materia_carrera", DbType.Int32, dxm.Mxcar.Id_Materias_x_Carrera));
          
            int retVal = (int)helper.EjecutarSql("SP_BAJA_MATERIAxCURSO", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");
            
            return retVal > 0;
        }

        public List<Materia> GetMaterias()
        {
            List<Materia> lst = new();
            SqlCommand cmd = new();
            DataTable table = helper.ConsultaSQL(cmd, "SP_CONSULTAR_MATERIAS");

            foreach (DataRow row in table.Rows)
            {
                Materia oMateria = new Materia
                {
                    Id_Materia = Convert.ToInt32(row[0].ToString()),
                    NombreMateria = row[1].ToString(),
                    Estado = ((Estado)Convert.ToInt32(row[2])).ToString(),
                };
                lst.Add(oMateria);
            }
            lst = lst.Where(x => x.Estado == Estado.Habilitado.ToString()).ToList();
            return lst;
        }

        public DataTable PlandeEstudios(int idCarrera)
        {
            SqlCommand cmd = new SqlCommand();
            List<DbParameter> sqlParams = new List<DbParameter>();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@idCarrera", DbType.Int32, idCarrera));
            DataTable table = helper.ConsultaSQL(cmd, "SP_PLAN_ESTUDIOS", sqlParams);
            return table;
        }

        public DataTable ConsultaMateriasCarrera(int idcarrera, int idmateria) {

            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@idcarrera", DbType.Int32, idcarrera));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@idmateria", DbType.Int32, idmateria));
            DataTable dt = new DataTable();
            dt = helper.ConsultaSQL(cmd, "SP_CONSULTA_MATERIAS_CARRERA", sqlParams);
            return dt;

        }

        public bool InsertaMateriaCarrera(MateriasXCarrera oMateriasxCarrera) {


            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@idmateria", DbType.Int32, oMateriasxCarrera.Materia.Id_Materia));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@carga_horaria", DbType.Int32, oMateriasxCarrera.CargaHoraria));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@idcarrera", DbType.Int32, oMateriasxCarrera.Carrera.Id_Carrera));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@cuatrimestre", DbType.String, oMateriasxCarrera.Cuatrimestre));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@anio_dictado", DbType.Int32, oMateriasxCarrera.AnioDictado));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@dictado", DbType.String, oMateriasxCarrera.Dictado));

            int retVal = (int)helper.EjecutarSql("SP_ALTA_MATERIA_CARRERA", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");
            return retVal > 0;

        }

        public bool BajaMateriaCarrera(int idMateriaCarrera) {

            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@idmateriacarrera", DbType.Int32, idMateriaCarrera));
            int retVal = (int)helper.EjecutarSql("SP_BAJA_MATERIA_CARRERA", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");
            return retVal > 0;
        }

        public bool ActualizaMateriasxCarrera(MateriasXCarrera oMateriasxCarrera) {

            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@idmateriacarrera", DbType.Int32, oMateriasxCarrera.Id_Materias_x_Carrera));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@idmateria", DbType.Int32, oMateriasxCarrera.Materia.Id_Materia));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@carga_horaria", DbType.Int32, oMateriasxCarrera.CargaHoraria));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@idcarrera", DbType.Int32, oMateriasxCarrera.Carrera.Id_Carrera));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@cuatrimestre", DbType.String, oMateriasxCarrera.Cuatrimestre));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@anio_dictado", DbType.Int32, oMateriasxCarrera.AnioDictado));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@dictado", DbType.String, oMateriasxCarrera.Dictado));
            int retVal = (int)helper.EjecutarSql("SP_ACTUALIZA_MATERIAS_CARRERA", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");
            return retVal > 0;
        }

        public bool InsertaMateria(Materia oMateria)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@materia", DbType.String, oMateria.NombreMateria));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@estado", DbType.Int32, (int)Estado.Habilitado));
            int result = (int)helper.EjecutarSql("SP_ALTA_MATERIAS", cmd, CommandType.StoredProcedure, sqlParams, "NonQuery");
            return result != 0;
        }

        public bool DeleteMateria(int id)
        {
            SqlCommand cmd = new SqlCommand();
            string sql = $"UPDATE MATERIAS SET estado = 0 WHERE id_materia = {id}";
            int result = (int)helper.EjecutarSql(sql, cmd, CommandType.Text, null, "NonQuery");
            return result != 0;
        }

        public Materia GetMateriaById(int id)
        {
            Materia curso = new();
            SqlCommand cmd = new();
            string sql = $"SELECT* FROM MATERIAS WHERE id_materia = {id}";

            DataTable table = helper.ConsultaSQLNonSP(cmd, sql);

            foreach (DataRow row in table.Rows)
            {
                curso = ObjectMapping(row);
            }

            return curso;
        }

        private Materia ObjectMapping(DataRow row)
        {
            Materia oMateria = new Materia
            {
                Id_Materia = Convert.ToInt32(row[0].ToString()),
                NombreMateria = row[1].ToString(),
                Estado = ((Estado)Convert.ToInt32(row[2])).ToString(),
            };
            return oMateria;
        }

        public bool UpdateMateria(Materia materia)
        {
            SqlCommand cmd = new SqlCommand();
            string exist = $"SELECT * FROM MATERIAS WHERE materia = '{materia.NombreMateria}'";
            DataTable table = helper.ConsultaSQLNonSP(cmd, exist);
            if (table.Rows.Count == 1)
                return false;
            string sql = $"UPDATE MATERIAS SET materia = '{materia.NombreMateria}' WHERE id_materia = '{materia.Id_Materia}'";
            int result = (int)helper.EjecutarSql(sql, cmd, CommandType.Text, null, "NonQuery");
            return result != 0;
        }

        public DataTable GetCondiciones(string filtro)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@groupElegido", DbType.String, filtro));
            DataTable dt = new DataTable();
            dt = helper.ConsultaSQL(cmd, "SP_ESTADISTICAS_ALUMNOS", sqlParams);
            return dt;
        }

        public DataTable GetCondiciones(Dictionary<string, object> lst)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            foreach (var item in lst)
            {
                sqlParams.Add(HelperDao.CrearParametro(cmd, item.Key, DbType.Int32, item.Value));
            }

            DataTable dt = helper.ConsultaSQL(cmd, "SP_PROMEDIO_NOTAS", sqlParams);
            return dt;
        }
    }
}
