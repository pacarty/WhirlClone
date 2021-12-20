using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhirlClone.Models
{
    public class ThreadDisplay
    {
        public Thread Thread { get; set; }
        public Message NewMessage { get; set; }
        public List<Message> Messages { get; set; }
    }
}
