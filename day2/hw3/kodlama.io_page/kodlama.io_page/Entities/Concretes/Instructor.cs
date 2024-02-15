using kodlama.io_page.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io_page.Entities.Concretes;

public class Instructor:IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
