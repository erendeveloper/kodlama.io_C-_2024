using kodlama.io_page.Business.Abstracts;
using kodlama.io_page.DataAccess.Abstracts;
using kodlama.io_page.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category? GetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public void Remove(Category category)
    {
        _categoryDal.Remove(category);
    }

    public void RemoveAll()
    {
        _categoryDal.RemoveAll();
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }
}
