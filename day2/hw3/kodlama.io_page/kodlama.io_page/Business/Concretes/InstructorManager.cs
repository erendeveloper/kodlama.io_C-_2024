using kodlama.io_page.Business.Abstracts;
using kodlama.io_page.DataAccess.Abstracts;
using kodlama.io_page.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.Business.Concretes;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }
    public void Remove(Instructor instructor)
    {
        _instructorDal.Remove(instructor);
    }

    public void RemoveAll()
    {
        _instructorDal.RemoveAll();
    }

    public Instructor? GetById(int id)
    {
        return _instructorDal.GetById(id);
    }
    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }

    public void Update(Category category)
    {
        throw new NotImplementedException();
    }
}
