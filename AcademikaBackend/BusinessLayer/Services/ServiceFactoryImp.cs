using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Services
{
    public class ServiceFactoryImp : AbstractServiceFactory
    {
        public override IMateriasService CrearServiceMaterias()
        {
            return new MateriasService();
        }
    }
}
