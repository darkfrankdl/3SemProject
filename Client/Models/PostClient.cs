using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Client.Models
{
    public class PostClient
    {

        [Display(Name = "Posted at")]
        public DateTime TimeOfPost { get; set; }

        public string ?Username { get; set; }

        public String ?Text { get; set; }

        public String ?Title { get; set; }

        [Display(Name = "Category")]
        public String ?TopicCategoryName { get; set; }

        public int ?Points { get; set; }

        public override string ToString()
        {
            String str = "";
            str = Username + " "+ Title;

            return str;
        }

    }
}
