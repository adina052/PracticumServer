//using MyProject.Repositories.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MyProject.Repositories.Interfaces;

//using MyProject.EntityFrameworkCore;
//using MyProject.Repositories.Entities;
//using System;
using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace MyProjerct.Context
{
    public class DBContext:DbContext,IContext
    { 
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyProjectBsd;Trusted_Connection=True;");
        }
    }
}
