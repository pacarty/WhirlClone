﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhirlClone.Models
{
    public class TopicDisplay
    {
        public Topic Topic { get; set; }
        public List<Thread> Threads { get; set; }
    }
}
