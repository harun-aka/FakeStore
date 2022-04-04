using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using Core.Utilities.Results;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product car)
        {
            _productDal.Add(car);
            
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Product car)
        {
            _productDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.CarsListed);            
        }

        public IDataResult<Product> GetById(int carId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(c => c.Id == carId), Messages.CarsListed);
        }
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product car)
        {
            _productDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
