using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Models;

namespace User_Microservice.Services
{
    public interface IUserService
    {
        public User GetById(int id);
    }
}
