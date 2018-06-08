using DaycareProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.ViewModels
{
    public class ToddlerFormViewModel
    {

        public Student Student { get; set; }
        public Classroom Classroom { get; set; }
        public MealDescription MealDescription { get; set; }
        public FoodAmount FoodAmount { get; set; }
        public MealTime MealTime { get; set; }

        public IList<FoodAmount> Amounts { get; set; }
        public IList<MealDescription> Meals { get; set; }
    }
}
