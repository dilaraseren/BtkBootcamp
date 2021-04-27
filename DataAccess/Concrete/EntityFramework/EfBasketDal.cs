using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfBasketDal:EfEntityRepositoryBase<Basket,ETradeContext>,IBasketDal
    {
        public List<BasketDetailDto> GetBasketDetails()
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = from basket in context.Baskets
                             join product in context.Products
                             on basket.ProductId equals product.Id
                             join user in context.Users 
                             on basket.UserId equals user.Id
                             select new BasketDetailDto
                             {
                                 BasketId = basket.Id,
                                 ProductName = product.Name,
                                 UserFullName = $"{user.FirstName} {user.LastName}",
                                 Count = basket.Count,
                                 CreateDate = basket.CreateDate,
                                 Active = basket.Active
                             };
                return result.ToList();
            }
        }
    }
}
