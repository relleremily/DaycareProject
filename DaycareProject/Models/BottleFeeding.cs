using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.Models
{
    public class BottleFeeding
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int Ounce { get; set; }

        public Student Student { get; set; }
        public int StudentID { get; set; }
    }
}
