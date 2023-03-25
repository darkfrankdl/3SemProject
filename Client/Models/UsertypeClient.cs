using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class UsertypeClient
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

        public UsertypeClient ()
        {
            _usertype = "";
        }
    }
}
