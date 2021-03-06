using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailsDal)
        {
            _orderDetailDal = orderDetailsDal;
        }

        public IDataResult<List<OrderDetail>> GetAll()
        {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetailDal.GetAll());
        }

        public IResult Add(OrderDetail orderDetail)
        {
            _orderDetailDal.Add(orderDetail);
            return new SuccessResult();
        }

        public IResult Delete(int orderDetailId)
        {
            _orderDetailDal.Delete(new OrderDetail { Id=orderDetailId});
            return new SuccessResult();
        }

        public IResult Update(int orderDetailId)
        {
            _orderDetailDal.Update(new OrderDetail { Id=orderDetailId});
            return new SuccessResult();
        }
    }
}
