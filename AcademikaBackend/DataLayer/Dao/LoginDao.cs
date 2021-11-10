using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace AcademikaBackend.DataLayer.Dao
{
    public class LoginDao : ILoginDao
    {
        HelperDao helper = HelperDao.GetInstance();
        public int Login(Usuario user)
        {
            List<DbParameter> sqlParams = new List<DbParameter>();
            SqlCommand cmd = new SqlCommand();
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@NombreUsuario", DbType.String, user.NombreUsuario));
            sqlParams.Add(HelperDao.CrearParametro(cmd, "@Password", DbType.String, user.Password));
            int IdUser = (int)helper.EjecutarSql("SP_VALIDAR_USUARIO", cmd, CommandType.StoredProcedure, sqlParams, "Scalar");
            return IdUser;
        }
    }
}
