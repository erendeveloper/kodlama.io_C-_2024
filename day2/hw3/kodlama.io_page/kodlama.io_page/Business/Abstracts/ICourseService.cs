using kodlama.io_page.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.Business.Abstracts;

public interface ICourseService
{
    void Add(Course course);
    void Remove(Course course);
    void RemoveAll();
    Course? GetById(int id);
    List<Course> GetAll();
    List<Course> GetByCategoryId(int id);
    List<Course> GetByInstructorId(int id);
    void Update(Course course);
}
