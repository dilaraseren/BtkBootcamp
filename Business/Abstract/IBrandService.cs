using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetById(int id);

        IResult Add(Brand brand);
        IResult Delete(int brandId);
        IResult Update(int brandId);
    }

}
