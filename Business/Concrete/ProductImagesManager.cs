using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{

    public class ProductImageManager : IProductImageService
    {
        private IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public IResult Add(IFormFile file, ProductImage productsImage)
        {
            var imageCount = _productImageDal.GetAll(c => c.ProductId == productsImage.ProductId).Count;
            if (imageCount >= 5)
            {
                return new ErrorResult("One product must have 5 or less images");
            }
            var imageResult = FileHelper.Upload(file);
            if (!imageResult.Success)
            {
                return new ErrorResult(imageResult.Message);
            }
            productsImage.ImagePath = imageResult.Message;
            _productImageDal.Add(productsImage);
            return new SuccessResult("Product image added");
        }

        public IResult Delete(ProductImage productImage)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(IFormFile file, ProductImage productImage)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<ProductImage> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll());
        }

        public IDataResult<List<ProductImage>> GetImagesByProductId(int id)
        {
            throw new System.NotImplementedException();
        }
        //business rules

        private IResult CheckImageLimitExceeded(int productId)
        {
            var productsImageCount = _productImageDal.GetAll(p => p.ProductId == productId).Count;
            if (productsImageCount >= 5)
            {
                return new ErrorResult("Limit");
            }

            return new SuccessResult();
        }

        private IDataResult<List<ProductImage>> CheckIfCarImageNull(int id)
        {
            try
            {
                string path = @"\images\logo.jpg";
                var result = _productImageDal.GetAll(c => c.ProductId == id).Any();
                if (!result)
                {
                    List<ProductImage> productImages = new List<ProductImage>();
                    productImages.Add(new ProductImage { ProductId = id, ImagePath = path, Date = DateTime.Now });
                    return new SuccessDataResult<List<ProductImage>>(productImages);
                }
            }
            catch (Exception exception)
            {

                return new ErrorDataResult<List<ProductImage>>(exception.Message);
            }

            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetAll(p => p.ProductId == id).ToList());
        }
        private IResult CarImageDelete(ProductImage carImage)
        {
            try
            {
                File.Delete(carImage.ImagePath);
            }
            catch (Exception exception)
            {

                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
    }
}
