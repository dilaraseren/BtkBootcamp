using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> GetAll();
        IDataResult<List<City>> GetByCountryId(int countryId);

        IResult Add(City city);
        IResult Delete(int cityId);
        IResult Update(int cityId);
    }

}
