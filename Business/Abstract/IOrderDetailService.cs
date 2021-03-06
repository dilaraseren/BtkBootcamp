using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOrderDetailService
    {
        IDataResult<List<OrderDetail>> GetAll();

        IResult Add(OrderDetail orderDetail);
        IResult Delete(int orderDetailId);
        IResult Update(int  orderDetailId);

    }

}
