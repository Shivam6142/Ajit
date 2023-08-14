using Ajit.Data;
using Ajit.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ajit.Controllers
{
    public class StudentController : Controller
    {
        StudentDBContext studentDBContext;
        public StudentController(StudentDBContext _studentDBContext)
        {
            studentDBContext = _studentDBContext;
        }


        //list all students
        public IActionResult Index()
        {
            IEnumerable<Student> students = studentDBContext.Students;
            return View(students);
        }

        //show create page 
        public IActionResult Create()
        {            
            return View();
        }


        //post created student data
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                studentDBContext.Students.Add(student);
                studentDBContext.SaveChanges();
                return RedirectToAction("Index");
                
            }
            return View(student);
        }

        //public IActionResult Edit()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Edit(Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        studentDBContext.Students.Add(student);
        //        studentDBContext.SaveChanges();
        //        return RedirectToAction("Index");

        //    }
        //    return View(student);
        //}





    }
}
