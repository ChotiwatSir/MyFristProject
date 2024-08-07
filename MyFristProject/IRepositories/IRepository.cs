using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFristProject.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> Table { get; }

    }
}