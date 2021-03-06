using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RPM_3_Course.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public DbSet<Post> Posts { get; set; }
        public DbSet<Picturee> Picturee {get;set;}

        public DbSet<FileModel> Files { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Pictureepost> Pictureepost { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

            Database.EnsureCreated();
        } // создание базы данных если её нет

    }
    
}
