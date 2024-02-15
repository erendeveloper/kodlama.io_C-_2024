using kodlama.io_page.DataAccess.Abstracts;
using kodlama.io_page.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> instructors;

    public InstructorDal()
    {
        instructors = new List<Instructor>();
    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }
    public void Remove(Instructor instructor)
    {
        instructors.Remove(instructor);
    }
    public void RemoveAll()
    {
        instructors.Clear();
    }
    public Instructor? GetById(int id)
    {
        return instructors.SingleOrDefault(i => i.Id == id);
    }
    public List<Instructor> GetAll()
    {
        return instructors;
    }
    public void Update(Instructor _instructor)
    {
        Instructor? instructor = GetById(_instructor.Id);
        if (instructor != null)
        {
            if (instructor.Id == _instructor.Id)
            {
                instructor.Name = _instructor.Name;
            }
        }
    }
}
