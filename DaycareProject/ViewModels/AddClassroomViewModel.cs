using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.ViewModels
{
    public class AddClassroomViewModel
    {
        [Required]
        [Display(Name = "Classroom Name")]
        public string ClassroomName { get; set; }
    }
}
