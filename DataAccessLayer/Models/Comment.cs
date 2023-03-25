using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer.Models
{
    public class Comment
    {
        [Display(Name = "Posted at")]
        public DateTime DateTime { get; set; }

        public String ?Username { get; set; }

        public String ?Text { get; set; }    

        public DateTime PostDateTime { get; set; }

        public string ?PostUsername { get; set; }

    }
}
