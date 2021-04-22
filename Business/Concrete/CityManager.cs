using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());
        }

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult();
        }

        public IResult Delete(int cityId)
        {
            _cityDal.Delete(new City { Id=cityId});
            return new SuccessResult();
        }

        public IResult Update(int cityId)
        {
            _cityDal.Update(new City { Id = cityId });
            return new SuccessResult();
        }

        public IDataResult<List<City>> GetByCountryId(int countryId)
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(c => c.CountryId == countryId));
        }
    }
}
