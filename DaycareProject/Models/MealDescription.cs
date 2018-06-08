using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.Models
{
    public class MealDescription
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Student Student { get; set; }
        public int StudentID { get; set; }

        public MealTime MealTime { get; set; }
        public int MealTimeID { get; set; }
        public string Name { get; set; }

        public FoodAmount FoodAmount { get; set; }
        public int FoodAmountID { get; set; }

        public IList<MealDescription> Meals { get; set; }
    }
}
