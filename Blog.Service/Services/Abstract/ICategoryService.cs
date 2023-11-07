﻿using Blog.Entity.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstract
{
    public interface ICategoryService
    {
        public Task<List<ViewCategory>> GetAllCategoriesNonDeleted();
    }
}
