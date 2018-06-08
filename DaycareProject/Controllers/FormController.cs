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
    public class FormController : Controller
    {

        private readonly DaycareDbContext context;

        public FormController(DaycareDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult AddMeal ()
        {
            AddMealViewModel addMealViewModel = new AddMealViewModel(context.MealTimes.ToList(), context.FoodAmounts.ToList());
            return View(addMealViewModel);
        }

        [HttpPost]
        public IActionResult AddMeal(AddMealViewModel addMealViewModel, int id)
        {
            if (ModelState.IsValid)
            {
                //var StudentID = addMealViewModel.StudentID; 
                Student student = context.Students.Single(s => s.ID == id);

                FoodAmount newFoodAmount =
                    context.FoodAmounts.Single(f => f.ID == addMealViewModel.FoodAmountID);

                MealTime newMealTime =
                    context.MealTimes.Single(m => m.ID == addMealViewModel.MealTimeID);

                MealDescription newMealDescription = new MealDescription
                {
                    StudentID = student.ID,
                    Description = addMealViewModel.Description,
                    MealTime = newMealTime,
                    FoodAmount = newFoodAmount
                };

                context.MealDescriptions.Add(newMealDescription);
                context.SaveChanges();

                return Redirect(string.Format("/Form/ToddlerForm/{0}", student.ID));
            }

            return View(addMealViewModel);

        }

        public IActionResult ToddlerForm(int id)
        {
            Student student = context.Students.Single(s => s.ID == id);
            Classroom classroom = context.Classrooms.Single(c => c.ID == student.ClassroomID);
            //DateTime Date = DateTime.UtcNow;

            //List<FoodAmount> amounts = context.FoodAmounts.ToList();

            List<MealDescription> meals = context
                .MealDescriptions
                //.Include(amount => amount.Description)
                //.Include(time => time.MealTime)
                .Where(s => s.StudentID == id)
                .ToList();

            ToddlerFormViewModel viewModel = new ToddlerFormViewModel
            {
                Student = student,
                Classroom = classroom,
                Meals = meals,
                //Amounts = amounts
            };
            return View(viewModel);

        }

        public IActionResult InfantForm(int id)
        {
            Student student = context.Students.Single(s => s.ID == id);
            Classroom classroom = context.Classrooms.Single(c => c.ID == student.ClassroomID);

            // var nwTm = DateTime.UtcNow.ToShortTimeString();



        List<BottleFeeding> bottleFeedings = context
                .BottleFeedings
                .Where(s => s.StudentID == id)
                .ToList();
            InfantFormViewModel viewModel = new InfantFormViewModel
            {
                Student = student,
                Classroom = classroom,
                BottleFeedings = bottleFeedings,
            };

            return View(viewModel);

        }
        public IActionResult AddBottleFeeding()
        {
            AddBottleFeedingViewModel addBottleFeedingViewModel = new AddBottleFeedingViewModel();
            return View(addBottleFeedingViewModel);
        }

        [HttpPost]
        public IActionResult AddBottleFeeding(AddBottleFeedingViewModel addBottleFeedingViewModel, int id)
        {
            if (ModelState.IsValid)
            {
                //var StudentID = addMealViewModel.StudentID; 
                Student student = context.Students.Single(s => s.ID == id);

                BottleFeeding newBottleFeeding = new BottleFeeding
                {
                    StudentID = student.ID,
                    Date = addBottleFeedingViewModel.Date,
                    Ounce = addBottleFeedingViewModel.Ounce
                };

                context.BottleFeedings.Add(newBottleFeeding);
                context.SaveChanges();

                return Redirect(string.Format("/Form/InfantForm/{0}", student.ID));
            }

            return View(addBottleFeedingViewModel);

        }
    }
}
