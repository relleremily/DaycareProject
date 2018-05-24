using DaycareProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.ViewModels
{
    public class ClassListViewModel
    {
        public Classroom Classroom { get; set; }
        public Student Student { get; set; }

        public IList<Student> Students { get; set; }
    }
}
