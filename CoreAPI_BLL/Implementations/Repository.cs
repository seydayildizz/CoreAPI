﻿using CoreAPI_BLL.Interfaces;
using CoreAPI_DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CoreAPI_BLL.Implementations
{
    public class Repository<T> : IRepositoryBase<T> where T : class, new()
    {
        protected readonly MyContext _myContext;

        public Repository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public bool Add(T entity)
        {
            try
            {
                bool result = false;
                _myContext.Set<T>().Add(entity);
                result = _myContext.SaveChanges() > 0 ? true : false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                bool result = false;
                _myContext.Set<T>().Remove(entity);
                result = _myContext.SaveChanges() > 0 ? true : false;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T GetById(int id)
        {
            try
            {
                return _myContext.Set<T>().Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            try
            {
                IQueryable<T> query = _myContext.Set<T>();
                //myCustomerRepo.Queryable().Where()
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                //ilişkili olduğu tabloyu dahil etmek amacıyla include yapısı eklendi
                if (includeProperties != null)
                {
                    foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(item);

                    }
                }
                if (orderBy != null)
                {
                    return orderBy(query);
                }
                return query;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            try
            {
                IQueryable<T> query = _myContext.Set<T>();
                //myCustomerRepo.Queryable().Where()
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                //ilişkili olduğu tabloyu dahil etmek amacıyla include yapısı eklendi
                if (includeProperties != null)
                {
                    foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(item);

                    }
                }
                return query.FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                bool result = false;
                _myContext.Set<T>().Update(entity);
                result = _myContext.SaveChanges() > 0 ? true : false;
                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
