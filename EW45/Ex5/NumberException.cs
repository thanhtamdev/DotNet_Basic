﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class NumberException : Exception
    {
        public NumberException(string message) : base(message)
        {

        }
    }
}
