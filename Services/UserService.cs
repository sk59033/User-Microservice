using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Models;
using User_Microservice.Repository;

namespace User_Microservice.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;
        public readonly ApplicationContext applicationContext;

        public UserService(IGenericRepository<User> genericRepository, ApplicationContext applicationContext)
        {
            _genericRepository = genericRepository;
            this.applicationContext = applicationContext;
        }

        public User GetById(int id)
        {
            var user = this.applicationContext.User.FirstOrDefault(x => x.Id == id);
            return user;
        }
    }
}
