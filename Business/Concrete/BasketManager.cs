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
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public IResult Add(Basket basket)
        {
            _basketDal.Add(basket);
            return new SuccessResult(Messages.SuccessAdded);
        }

        public IDataResult<List<Basket>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Basket>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll(), Messages.SuccessListed);
        }

        public IDataResult<List<Basket>> GetByProductId(int productId)
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll(p => p.ProductId == productId));
        }
    }
}
