using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaycareProject.Data;
using DaycareProject.Models;
using DaycareProject.ViewModels;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaycareProject.Controllers
{
    public class SignInController : Controller
    {

        private readonly DaycareDbContext context;

        public SignInController(DaycareDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authorize(SignInViewModel signInViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = context.Users.Where(u => u.Username == signInViewModel.Username && u.Password == signInViewModel.Password).FirstOrDefault();

                if (user == null)
                {
                    return Redirect("/SignIn");
                }

                else
                {
                    //this.Request.HttpContext.Session["ID"] = "user.ID";
                    //HttpContext context = HttpContext.Request;
                    //this.HttpContext.Session.Set("ID", user.ID);
                    //SessionExtensions.SetString(this.HttpContext.Session, "ID", ""+user.ID);
                    return Redirect("/Classroom/Index");

                }

            }
            return View();
        }
    }
}