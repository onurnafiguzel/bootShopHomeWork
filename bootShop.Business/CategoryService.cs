using AutoMapper;
using bootShop.DataAccess.Data;
using bootShop.DataAccess.Repositories;
using bootShop.Dtos.Responses;
using bootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Business
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository repository;
        private readonly IMapper mapper;

        public CategoryService(bootShopDbContext dbContext, ICategoryRepository repository = null, IMapper mapper = null)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public IList<Category> GetCategories()
        {
            return repository.GetAllCategories();
        }
    }
}
