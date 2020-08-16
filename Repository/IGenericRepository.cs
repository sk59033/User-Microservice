﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Microservice.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(long id);
    }
}
