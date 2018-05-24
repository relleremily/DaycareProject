using DaycareProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [Required]
        [Display(Name = "Classroom")]
        public int ClassroomID { get; set; }

        public List<SelectListItem> Classrooms { get; set; }

        public AddStudentViewModel(IEnumerable<Classroom> classrooms)
        {
            Classrooms = new List<SelectListItem>();

            foreach (var classroom in classrooms)
            {
                Classrooms.Add(new SelectListItem

                {
                    Value = classroom.ID.ToString(),
                    Text = classroom.ClassroomName
                });
            }

            this.Classrooms = Classrooms;
        }

        public AddStudentViewModel() { }
    }
}
