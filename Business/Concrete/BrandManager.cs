using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.SuccessAdded);
        }

        public IResult Delete(int brandId)
        {
            _brandDal.Delete(new Brand { Id=brandId});
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<List<Brand>> GetById(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(b=>b.Id==id));
        }

        public IResult Update(int brandId)
        {
            _brandDal.Update(new Brand { Id=brandId});
            return new SuccessResult(Messages.SuccessUpdated);
        }
    }
}
