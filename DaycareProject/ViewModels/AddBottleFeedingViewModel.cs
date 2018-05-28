using DaycareProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.ViewModels
{
    public class AddBottleFeedingViewModel
    {
        
        [Required]
        [Display(Name = "Ounces")]
        public int Ounce { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:H:mm}")]
        //[Display(Name = "Date and Time")]
        public DateTime Date { get; set; }

        [Required]
        public int StudentID { get; set; }

        public BottleFeeding BottleFeeding { get; set; }

    }
}
