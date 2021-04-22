using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public IDataResult<List<Country>> GetAll()
        {
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll());
        }

        public IResult Add(Country country)
        {
            _countryDal.Add(country);
            return new SuccessResult();
        }

        public IResult Delete(int countryId)
        {
            _countryDal.Delete(new Country { Id=countryId});
            return new SuccessResult();
        }

        public IResult Update(int countryId)
        {
            _countryDal.Update(new Country { Id=countryId});
            return new SuccessResult();
        }

        public IDataResult<List<Country>> GetById(int id)
        {
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll(c => c.Id == id));
        }
    }
}
