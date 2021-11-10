using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.DataLayer.Dao;
using System.Collections.Generic;

namespace AcademikaBackend.BusinessLayer.Services
{
    public class LoginService : ILoginService
    {
        private ILoginDao loginDao;

        public LoginService()
        {
            loginDao = new LoginDao();
        }

        public int IniciarSesion(Usuario usuario)
        {
            return loginDao.Login(usuario);
        }
    }
}
