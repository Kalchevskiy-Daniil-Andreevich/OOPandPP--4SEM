﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class L1B : IBonus
    {
        public float cost1hour { get; set; } = 0;
        public float x { get; set; } = 0;
        public L1B(float cost1hour, float x) 
        {
            this.cost1hour = cost1hour;
            this.x = x;
        }
        public float calc(float number_hours)
        {
            return number_hours * cost1hour * x;                                                                            //пов/пониж коэфф
        }
    }
}
