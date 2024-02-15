using kodlama.io_page.Business.Abstracts;
using kodlama.io_page.DataAccess.Abstracts;
using kodlama.io_page.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.Business.Concretes;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Remove(Course course)
    {
        _courseDal.Remove(course);
    }

    public void RemoveAll()
    {
        _courseDal.RemoveAll();
    }
    public Course? GetById(int id)
    {
        return _courseDal.GetById(id);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public List<Course> GetByCategoryId(int id)
    {
        return _courseDal.GetByCategoryId(id);
    }
    public List<Course> GetByInstructorId(int id)
    {
        return _courseDal.GetByInstructorId(id);
    }
    public void Update(Course course)
    {
        _courseDal.Update(course);
    }

    
}
