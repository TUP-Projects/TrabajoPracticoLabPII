﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.BusinessLayer.Services
{
    public abstract class AbstractServiceFactory
    {
         public abstract IAlumnosService CrearServiceAlumno();
    }
}
