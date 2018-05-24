using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }

        public Classroom Classroom { get; set; }
        public int ClassroomID { get; set; }


    }
}
