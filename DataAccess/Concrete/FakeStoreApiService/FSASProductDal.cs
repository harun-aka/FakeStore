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

        public List<Product> GetAll()
        {
            return _dbService.GetProducts();
        }

    }
}
