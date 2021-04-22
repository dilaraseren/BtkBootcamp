using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.SuccessAdded);
        }

        public IResult Delete(int categoryId)
        {
            _categoryDal.Delete(new Category { Id=categoryId});
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<List<Category>> GetById(int id)
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(c => c.Id == id));
        }

        public IResult Update(int categoryId)
        {
            _categoryDal.Update(new Category { Id=categoryId});
            return new SuccessResult(Messages.SuccessUpdated);
        }
    }
}
