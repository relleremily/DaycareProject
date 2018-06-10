using DaycareProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.ViewModels
{
    public class SignInViewModel
    {
        [Required(ErrorMessage ="Invalid Username or Password")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Invalid Username or Password")]
        public string Password { get; set; }

        public User User { get; set; }
    }
}
