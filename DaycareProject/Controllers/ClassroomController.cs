using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaycareProject.Data;
using DaycareProject.Models;
using DaycareProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DaycareProject.Controllers
{
    public class ClassroomController : Controller
    {
        private readonly DaycareDbContext context;

        public ClassroomController (DaycareDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<Classroom> classrooms = context.Classrooms.ToList();
            return View(classrooms);
        }

        public IActionResult Add()
        {
            AddClassroomViewModel addClassroomViewModel = new AddClassroomViewModel(context.Forms.ToList());
            return View(addClassroomViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddClassroomViewModel addClassroomViewModel)
        {
            if (ModelState.IsValid)
            {

                Form newForm =
                    context.Forms.Single(f => f.ID == addClassroomViewModel.FormID);
                Classroom newClassroom = new Classroom
                {
                    ClassroomName = addClassroomViewModel.ClassroomName,
                    Form = newForm
                };

                context.Classrooms.Add(newClassroom);
                context.SaveChanges();

                return Redirect("/Classroom");
            }

            return View(addClassroomViewModel);
        }

        public IActionResult ClassList (int id)
        {
            List<Student> students = context.Students
                .Where(c => c.ClassroomID == id)
                .ToList();

            Classroom classroom = context.Classrooms.Single(k => k.ID == id);

            ClassListViewModel viewModel = new ClassListViewModel
            {
                Classroom = classroom,
                Students = students
            };
            return View(viewModel);
        }

    }
}
