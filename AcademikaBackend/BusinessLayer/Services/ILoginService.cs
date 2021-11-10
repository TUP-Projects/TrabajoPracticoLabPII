using AcademikaBackend.BusinessLayer.Entities;
using System.Collections.Generic;

namespace AcademikaBackend.BusinessLayer.Services
{
    public interface ILoginService
    {
        public int IniciarSesion(Usuario usuario);
    }
}
