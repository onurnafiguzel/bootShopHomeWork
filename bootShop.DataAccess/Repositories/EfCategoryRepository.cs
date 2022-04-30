using bootShop.DataAccess.Data;
using bootShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.DataAccess.Repositories
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private bootShopDbContext context;

        public EfCategoryRepository(bootShopDbContext context)
        {
            this.context = context;
        }

        public IList<Category> GetAllCategories()
        {
            return context.Categories.ToList();
        }
    }
}
