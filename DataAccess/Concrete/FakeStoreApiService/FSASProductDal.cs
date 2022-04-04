using Core.DataAccess.EntityFramework;
using Core.Services.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class FSASProductDal : IProductDal
    {
        IDbService _dbService;

        public FSASProductDal(IDbService dbService)
        {
            _dbService = dbService;
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _dbService.GetProducts();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
