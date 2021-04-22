using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOrderStatusService
    {
        IDataResult<List<OrderStatus>> GetAll();

        IResult Add(OrderStatus orderStatus);
        IResult Delete(int orderStatusId);
        IResult Update(int orderStatusId);
    }

}
