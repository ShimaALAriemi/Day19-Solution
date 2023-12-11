using Day19.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19.MyDbContext
{
    internal class AplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-IFPCQQN\\MSSQLS;Initial Catalog=MakeenDay19;Integrated Security=True;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
