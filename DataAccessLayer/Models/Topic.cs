using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer.Models
{
    public class Topic
    {
        [Display(Name = "Category")]
        public string ?CategoryName { get; set; }

        [Display(Name = "New category name")]
        public string ?NewCategoryname { get; set; }
        public string ?Username { get; set; }

        public override string ToString()
        {
            String str = "";
            str = CategoryName;
            return str;
        }
    }
}
