﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppConsumingWCFService.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // --  Find object --
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        // --  Add Object --
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entity);

        // --  Remove Object  --
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
