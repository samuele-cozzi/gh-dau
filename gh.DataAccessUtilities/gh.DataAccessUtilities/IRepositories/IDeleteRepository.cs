﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gh.DataAccessUtilities.IRepositories
{
    public interface IDeleteRepository<T>

        where T : class
    {

        void Remove(T entity);

    }
}
