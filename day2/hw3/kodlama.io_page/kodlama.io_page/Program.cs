// See https://aka.ms/new-console-template for more information
using kodlama.io_page.Business.Concretes;
using kodlama.io_page.DataAccess.Concretes;
using kodlama.io_page.Entities.Concretes;

Category category1 = new Category(){ Id = 1, Name = "category1",};
Category category2 = new Category(){ Id = 2, Name = "category2",};
Category category3 = new Category(){ Id = 3, Name = "category3",};

Instructor instructor1 = new Instructor(){ Id = 4, Name = "instructor1",};
Instructor instructor2 = new Instructor(){ Id = 5, Name = "instructor2",};
Instructor instructor3 = new Instructor(){ Id = 6, Name = "instructor3",};

Course course1 = new Course(){ Id = 7, Name = "course1", CategoryId = 1, InstructorId = 4};
Course course2 = new Course(){ Id = 8, Name = "course2", CategoryId = 1, InstructorId = 5 };
Course course3 = new Course() { Id = 9, Name = "course3", CategoryId = 2, InstructorId = 4 };
Course course4 = new Course() { Id = 10, Name = "course4", CategoryId = 2, InstructorId = 5 };
Course course5 = new Course() { Id = 11, Name = "course5", CategoryId = 2, InstructorId = 5 };



CategoryManager categoryManager = new CategoryManager(new CategoryDal());
InstructorManager instructorManager = new InstructorManager(new InstructorDal());
CourseManager courseManager = new CourseManager(new CourseDal());

categoryManager.Add(category1);
categoryManager.Add(category2);
categoryManager.Add(category3);
categoryManager.Remove(category3);

instructorManager.Add(instructor1);
instructorManager.Add(instructor2);
instructorManager.Add(instructor3);
instructorManager.Remove(instructor3);

courseManager.Add(course1);
courseManager.Add(course2);
courseManager.Add(course3);
courseManager.Add(course4);
courseManager.Add(course5);
courseManager.Remove(course5);

foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine($"Id:{category.Id}, Name:{category.Name}");
}
foreach (var instructor in instructorManager.GetAll())
{
    Console.WriteLine("id:" + instructor.Id + "Name: " + instructor.Name);
}
foreach (var course in courseManager.GetAll())
{
    Console.WriteLine(String.Format("Id:{0}, Name:{1}", course.Id.ToString(), course.Name));
}

