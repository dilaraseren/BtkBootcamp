using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICountryService
    {
        IDataResult<List<Country>> GetAll();
        IDataResult<List<Country>> GetById(int id);

        IResult Add(Country country);
        IResult Delete(Country country);
        IResult Update(Country country);
    }

}
