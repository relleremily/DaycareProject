using DaycareProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.ViewModels
{
    public class InfantFormViewModel
    {
        public Student Student { get; set; }
        public Classroom Classroom { get; set; }
        public BottleFeeding BottleFeeding { get; set; }

        public IList<BottleFeeding> BottleFeedings { get; set; }
    }
}
