using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer.Models
{
    public class Person
    {
        public String ?Username { get; set; }    

        public String ?Password { get; set; }    



        [Display(Name = "User type")]
        public String ?Usertype { get; set; }

        public int? Points { get; set; }
    }
}
