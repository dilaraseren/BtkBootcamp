using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IDataResult<List<Address>> GetAll();
        IDataResult<List<Address>> GetByUserId(int userId);

        IResult Add(Address address);
        IResult Delete(Address address);
        IResult Update(Address address);
    }

}
