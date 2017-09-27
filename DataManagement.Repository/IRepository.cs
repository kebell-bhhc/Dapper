﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataManagement.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T Get(int id);
        bool Add(T entity);
        bool Delete(int id);
        bool Update(T entity);
    }
}
