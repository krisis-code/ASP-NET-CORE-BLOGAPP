﻿using Blog.Core.Entities;
using Blog.Data.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Abstractions
{
    public interface IRepository<T> where T : class , IEntityBase, new ()
    {
        Task addAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);

        Task<T> GetAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);

        Task<T> GuidAsync(Guid id);

        Task<T> UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<bool>> predicate);

        Task<int> CountAsync(Expression<Func<int>> predicate = null);

    }
}
