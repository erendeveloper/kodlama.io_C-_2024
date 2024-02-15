using kodlama.io_page.DataAccess.Abstracts;
using kodlama.io_page.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> categories;

    public CategoryDal()
    {
        categories = new List<Category>();
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }
    public void Remove(Category category)
    {
        categories.Remove(category);
    }
    public void RemoveAll()
    {
        categories.Clear();
    }
    public Category? GetById(int id)
    {
        return categories.SingleOrDefault(c => c.Id == id);
    }
    public List<Category> GetAll()
    {
        return categories;
    }
    public void Update(Category _category)
    {
        Category? category = GetById(_category.Id);
        if(category != null)
        {
            if (category.Id == _category.Id)
            {
                category.Name = _category.Name;
            }
        }     
    }
}
