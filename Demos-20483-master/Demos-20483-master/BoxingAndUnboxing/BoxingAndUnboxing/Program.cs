﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 25;

            object obj = i;  //Boxing

            int x = (short)obj; //Unboxing
        }
    }
}
