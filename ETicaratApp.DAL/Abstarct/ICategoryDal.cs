﻿using ETicaratApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Abstarct
{
    public interface ICategoryDal
    {
        List<Category> ListAllCategory();
        void AddCategory(Category category);

        void DeleteCategory(Category category);

        void UpdateCategory(Category category);

        Category GetById(int Id);

    }
}

//
