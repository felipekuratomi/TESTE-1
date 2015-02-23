﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Colletion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCollection list = new StringCollection();
            list.Add("banana");
            list.Add("teste");
            list.Add("asdfasdf");

            var query = from string item in list
                        where item.Length > 5
                        select item;
        }
    }
}
