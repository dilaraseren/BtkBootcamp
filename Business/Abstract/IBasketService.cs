using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBasketService
    {
        IDataResult<List<Basket>> GetAll();
        IDataResult<List<Basket>> GetByProductId(int productId);

        IResult Add(Basket basket);
        IResult Update(int basketId);
        IResult Delete(int basketId);
    }
}
