using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Message { 

    
        public String ?UsernameSender { get; set; }  

        public String ?UsernameReceiver { get; set; }

        public DateTime ?DateTime { get; set; }  

        public String ?Text { get; set; }    
    }
}
