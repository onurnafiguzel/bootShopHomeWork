using bootShop.DataAccess.Repositories;
using bootShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootShop.Business
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public User ValidateUser(string userName, string password)
        {
            return repository.ValidateUser(userName, password);
        }
    }
}
