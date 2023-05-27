﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Abstarct
{
    public interface IGenericDal<T> where T : class
    {   
        void insert (T t);

        void delete(T t);

        void update(T t);

        List<T> getListAll();

        T GetByID (int id);

    }
}
