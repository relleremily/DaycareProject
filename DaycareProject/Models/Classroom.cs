using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.Models
{
    public class Classroom
    {
        public int ID { get; set; }
        public string ClassroomName { get; set; }

        public Form Form { get; set; }
        public int FormID { get; set; }


        public IList<Student> Students { get; set; }

        
    }
}
