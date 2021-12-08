using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPM_3_Course.Models
{
    public class PostViewModel : DbContext
    {
        public IEnumerable<User> users { get; set; }
        public IEnumerable<Post> posts { get; set; }
        public IEnumerable<Pictureepost> pictureeposts { get; set; }
        
        public DbSet<Post> Posts { get; set; }
        public DbSet<Pictureepost> Pictureeposts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
