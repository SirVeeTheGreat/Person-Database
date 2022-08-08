using Microsoft.EntityFrameworkCore;
using Person__DB.BL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person__DB.DAL
{
    public class PersonContext :DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=Persons.db");
        }
    }
}
