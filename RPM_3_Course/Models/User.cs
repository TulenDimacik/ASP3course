using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RPM_3_Course.Models
{
    public class User
    {
        [Key]
       
        public int Id { get; set; }
  
        public string Last_Name { get; set; }

        public string First_Name { get; set; }

        public string Middle_Name { get; set; }

        public string Date_Of_Birth { get; set; }

        //[Remote(action: "CheckEmail", controller: "Home", ErrorMessage = "Email уже используется")]
        public string Email { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        [ForeignKey("RolesId")]
        public int RolesId { get; set; }

        // public Roles Roles { get; set; }

        [ForeignKey("PictureeId")]
        public int PictureeId { get; set; }
       // [ForeignKey("PictureeId")]
        //public Picturee Picturee { get; set; }

       

    }
    public enum SortState
    {
        IdAsc,
        IdDesc,
        EmailAsc,
        EmailDesc
    }
}
