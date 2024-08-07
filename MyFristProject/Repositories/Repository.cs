using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyFristProject.Contexts;
using MyFristProject.IRepositories;

namespace MyFristProject.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly MyContext _myContext;

        public Repository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public IQueryable<TEntity> Table => _myContext.Set<TEntity>();
    }
}