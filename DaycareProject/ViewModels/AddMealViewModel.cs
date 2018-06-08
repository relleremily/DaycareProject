using DaycareProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.ViewModels
{
    public class AddMealViewModel
    {
        [Required]
        [Display(Name = "Meal Descrption")]
        public string Description { get; set; }

        //[Required]
        //[Display(Name = "Date")]
        //public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Name")]
        public int MealTimeID { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public int FoodAmountID { get; set; }

        [Required]
        public int StudentID { get; set; }

        public MealDescription MealDescription { get; set; }

        public FoodAmount FoodAmount { get; set; }
        public List<SelectListItem> FoodAmounts { get; set; }

        public MealTime MealTime { get; set; }
        public List<SelectListItem> MealTimes { get; set; }

        public AddMealViewModel(IEnumerable<MealTime> mealTimes, IEnumerable<FoodAmount> foodAmounts)
        {   MealTimes = new List<SelectListItem>();

            FoodAmounts = new List<SelectListItem>();

            foreach (var mealTime in mealTimes)
            {
                MealTimes.Add(new SelectListItem
                {
                    Value = mealTime.ID.ToString(),
                    Text = mealTime.Name
                });

            foreach (var foodAmount in foodAmounts)
            {
                FoodAmounts.Add(new SelectListItem
                {
                    Value = foodAmount.ID.ToString(),
                    Text = foodAmount.Amount
                });
            }
            }
            this.FoodAmounts = FoodAmounts;

            this.MealTimes = MealTimes;
        }


        public AddMealViewModel() { }
    }
}
