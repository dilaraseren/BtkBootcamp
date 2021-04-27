using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductImageService
    {
        IResult Add(IFormFile file, ProductImage productsImage);
        IResult Delete(ProductImage productsImage);
        IResult Update(IFormFile file, ProductImage productsImage);
        IDataResult<ProductImage> Get(int id);
        IDataResult<List<ProductImage>> GetAll();
        IDataResult<List<ProductImage>> GetImagesByProductId(int id);
    }
}
