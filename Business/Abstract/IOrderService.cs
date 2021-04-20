using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<List<Order>> GetByOrderStatusId(int orderStatusId);

        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
    }

}
