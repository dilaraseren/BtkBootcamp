﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult();
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult();
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult();
        }

        public IDataResult<List<Order>> GetByOrderStatusId(int orderStatusId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(o=>o.OrderStatusId==orderStatusId));
        }
    }
}
