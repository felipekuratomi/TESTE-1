﻿using MVVMDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Cliente = new Cliente
            {
                    Nome="Fulano",
                    Sobrenome="Silva"
            };
        }
        public Cliente Cliente { get; set; }

    }
}