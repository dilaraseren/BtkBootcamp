using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ETradeContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails(Expression<Func<ProductDetailDto, bool>> filter = null)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             join b in context.Brands
                             on p.BrandId equals b.Id

                             select new ProductDetailDto
                             {
                                 ProductId = p.Id,
                                 Images =
                            (from i in context.ProductImages where i.ProductId == p.Id select i.ImagePath).ToList(),
                                 CategoryName = c.Name,
                                 BrandName = b.Name,
                                 ProductName = p.Name,
                                 Code = p.Code,
                                 Price = p.Price,
                                 CreateDate = p.CreateDate,
                                 Active = p.Active,

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}