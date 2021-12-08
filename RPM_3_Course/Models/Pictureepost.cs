using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPM_3_Course.Models
{
    public class Pictureepost
    {
        [Key]
        public int Id { get; set; }
        public string Name_Picture { get; set; }
        public string Path { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}
