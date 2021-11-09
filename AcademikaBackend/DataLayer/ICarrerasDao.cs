﻿using AcademikaBackend.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaBackend.DataLayer
{
    public interface ICarrerasDao
    {
        int ObtenerProxId(string tabla); 
        List<Carrera> GetCarreras();
    }
}
