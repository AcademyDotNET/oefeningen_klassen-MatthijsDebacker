﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moederbord
{
    class ISA
    {
        public override string ToString()
        {
            return $"{this.GetType().Name}";
        }
    }
}
