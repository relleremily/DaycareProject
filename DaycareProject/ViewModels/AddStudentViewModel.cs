using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.ViewModels
{
    public class AddStudentViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string StudentFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string StudentLastName { get; set; }
    }
}
