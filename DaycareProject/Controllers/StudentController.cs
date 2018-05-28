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
            AddStudentViewModel addStudentViewModel = new AddStudentViewModel (context.Classrooms.ToList());
            return View(addStudentViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddStudentViewModel addStudentViewModel)
        {
            if (ModelState.IsValid)
            {
                Classroom newClassroom =
                    context.Classrooms.Single(c => c.ID == addStudentViewModel.ClassroomID);
                Student newStudent = new Student
                {
                    StudentFirstName = addStudentViewModel.StudentFirstName,
                    StudentLastName = addStudentViewModel.StudentLastName,
                    Classroom = newClassroom
                };

                context.Students.Add(newStudent);
                context.SaveChanges();

                return Redirect("/Student");
            }

            return View(addStudentViewModel);
        }

        public IActionResult GetDailyForm (int id)
        {
            Student student = context.Students.Single(s => s.ID == id);
            Classroom classroom = context.Classrooms.Single(c => c.ID == student.ClassroomID);
            Form form = context.Forms.Single(f => f.ID == classroom.FormID);


            if (form.ID == 1)
            {
                return Redirect(string.Format("/Form/InfantForm/{0}", student.ID));
            }

            else if (form.ID == 2)
            {
                return Redirect(string.Format("/Form/ToddlerForm/{0}", student.ID));
            }


            return View();
        }
    }
}
