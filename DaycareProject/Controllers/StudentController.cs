using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaycareProject.Data;
using DaycareProject.Models;
using DaycareProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DaycareProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly DaycareDbContext context;

        public StudentController(DaycareDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            IList<Student> students = context.Students.ToList();
            return View(students);
        }

        public IActionResult Add()
        {
            AddStudentViewModel addStudentViewModel = new AddStudentViewModel();
            return View(addStudentViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddStudentViewModel addStudentViewModel)
        {
            if (ModelState.IsValid)
            {
                Student newStudent = new Student
                {
                    StudentFirstName = addStudentViewModel.StudentFirstName,
                    StudentLastName = addStudentViewModel.StudentLastName
                };

                context.Students.Add(newStudent);
                context.SaveChanges();

                return Redirect("/Student");
            }

            return View(addStudentViewModel);
        }
    }
}
