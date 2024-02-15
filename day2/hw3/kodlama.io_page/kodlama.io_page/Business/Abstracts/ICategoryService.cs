using kodlama.io_page.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.Business.Abstracts;

public interface ICategoryService
{
    void Add(Category category);
    void Remove(Category category);
    void RemoveAll();
    Category? GetById(int id);
    List<Category> GetAll();
    void Update(Category category);
}
