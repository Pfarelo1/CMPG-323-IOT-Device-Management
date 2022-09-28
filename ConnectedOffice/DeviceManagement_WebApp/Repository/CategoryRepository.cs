﻿using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Category GetMostRecentCategory()
        {
            return _context.Category.OrderByDescending(Category => Category.DateCreated).FirstOrDefault();
        }
    }

}