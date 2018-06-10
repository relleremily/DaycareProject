using DaycareProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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


        [Required]
        [Display(Name = "Class Form")]
        public int FormID { get; set; }

        public List<SelectListItem> Forms { get; set; }

        public AddClassroomViewModel(IEnumerable<Form> forms)
        {
            Forms = new List<SelectListItem>();

            foreach (var form in forms)
            {
                Forms.Add(new SelectListItem
                {
                    Value = form.ID.ToString(),
                    Text = form.Name
                });
            }
            this.Forms = Forms;
        }
        public AddClassroomViewModel() { }
    }
}
