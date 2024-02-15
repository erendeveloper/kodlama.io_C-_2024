using kodlama.io_page.DataAccess.Abstracts;
using kodlama.io_page.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        courses = new List<Course>();
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
    public void Remove(Course course)
    {
        courses.Remove(course);
    }
    public void RemoveAll()
    {
        courses.Clear();
    }
    public Course? GetById(int id)
    {
        return courses.SingleOrDefault(c => c.Id == id);
    }
    public List<Course> GetAll()
    {
        return courses;
    }
    public List<Course> GetByCategoryId(int id)
    {
        return courses.Where(c => c.CategoryId == id).ToList();
    }

    public List<Course> GetByInstructorId(int id)
    {
        return courses.Where(c => c.InstructorId == id).ToList();
    }
    public void Update(Course _course)
    {
        Course? course = GetById(_course.Id);
        if (course != null)
        {
            if (course.Id == _course.Id)
            {
                course.Name = _course.Name;
            }
        }
    }
}
