using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Client.Models
{
    public class PersonClient
    {
        public String ?Username { get; set; }    

        public String ?Password { get; set; }    



        [Display(Name = "User type")]
        public String ?Usertype { get; set; }

        public int? Points { get; set; }

        public override string ToString()
        {
            String str = "";
            str = Username;
            return str;
        }
    }
}
