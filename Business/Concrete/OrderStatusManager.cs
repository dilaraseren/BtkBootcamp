using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    public class OrderStatusManager : IOrderStatusService
    {
        IOrderStatusDal _orderStatusDal;

        public OrderStatusManager(IOrderStatusDal orderStatusDal)
        {
            _orderStatusDal = orderStatusDal;
        }

        public IDataResult<List<OrderStatus>> GetAll()
        {
            return new SuccessDataResult<List<OrderStatus>>(_orderStatusDal.GetAll());
        }

        public IResult Add(OrderStatus orderStatus)
        {
            _orderStatusDal.Add(orderStatus);
            return new SuccessResult();
        }

        public IResult Delete(int orderStatusId)
        {
            _orderStatusDal.Delete(new OrderStatus { Id=orderStatusId});
            return new SuccessResult();
        }

        public IResult Update(int orderStatusId)
        {
            _orderStatusDal.Update(new OrderStatus { Id = orderStatusId });
            return new SuccessResult();
        }
    }
}