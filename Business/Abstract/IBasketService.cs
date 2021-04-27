using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBasketService
    {
        IDataResult<List<Basket>> GetAll();
        IDataResult<List<Basket>> GetByProductId(int productId);
        IDataResult<List<BasketDetailDto>> GetBasketDetails();
        IResult Add(Basket basket);
        IResult Update(int basketId);
        IResult Delete(int basketId);
    }
}
