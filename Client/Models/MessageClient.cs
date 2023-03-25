using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class MessageClient { 

    
        public String ?UsernameSender { get; set; }  

        public String ?UsernameReceiver { get; set; }

        public DateTime ?DateTime { get; set; }  

        public String ?Text { get; set; }    
    }
}
