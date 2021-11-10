using AcademikaBackend.BusinessLayer.Entities;
using System.Collections.Generic;

namespace AcademikaBackend.DataLayer.Dao
{
    public interface ILoginDao
    {
        int Login(Usuario usuario);
    }
}
