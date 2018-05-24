using DaycareProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaycareProject.Data
{
    public class DaycareDbContext : DbContext
    {
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<MealTime> MealTimes { get; set; }

        public DaycareDbContext(DbContextOptions<DaycareDbContext> options)
            : base(options)
        { }
    }
}
