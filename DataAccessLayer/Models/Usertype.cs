using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Usertype
    {
        private string _usertype;
        public string Type 
        {
            get
            {
                return _usertype;
            }

            set
            {
                _usertype = value;
            }
        }

        public Usertype ()
        {
            _usertype = "";
        }
    }
}
