using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Microservice.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;

        public GenericRepository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();

        }

        public T GetById(long id)
        {
            return entities.Find(id);
        }
    }
}
