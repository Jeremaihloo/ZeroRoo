﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Command
{
    public class CommandAttribute : Attribute
    {
        public CommandAttribute()
        {

        }

        public string Name { get; set; }

        public string Alias { get; set; }
    }
}
