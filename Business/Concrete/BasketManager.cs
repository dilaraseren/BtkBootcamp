using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Delete(int basketId)
        {

            _basketDal.Delete(new Basket {Id=basketId });
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<Basket>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Basket>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll(), Messages.SuccessListed);
        }

        public IDataResult<List<BasketDetailDto>> GetBasketDetails()
        {
            return new SuccessDataResult<List<BasketDetailDto>>(_basketDal.GetBasketDetails(), Messages.SuccessListed);
        }

        public IDataResult<List<Basket>> GetByProductId(int productId)
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll(p => p.ProductId == productId));
        }

        public IResult Update(int basketId)
        {
            _basketDal.Update(new Basket { Id = basketId });
            return new SuccessResult(Messages.SuccessUpdated);
        }
    }
}
