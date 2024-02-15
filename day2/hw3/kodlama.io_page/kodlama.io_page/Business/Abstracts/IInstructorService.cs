using kodlama.io_page.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.Business.Abstracts;

public interface IInstructorService
{
    void Add(Instructor instructor);
    void Remove(Instructor instructor);
    void RemoveAll();
    Instructor? GetById(int id);
    List<Instructor> GetAll();
    void Update(Instructor instructor);
}
