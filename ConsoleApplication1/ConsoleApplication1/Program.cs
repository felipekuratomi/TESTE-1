﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x="fadfadbf";
            //var joaquim = new Pessoa
            //{
            //    Nome = "Joaquim",
            //    Idade = 10,
            //    Sobrenome = "baskdhrjkoqwehr",
            //};
            ////*** PONTEIRO
            //Console.WriteLine(joaquim.Nome);
            //var Pessoa2 = joaquim;
            //joaquim.Sobrenome = "MUDOU";
            //Console.WriteLine(Pessoa2.Sobrenome);

            //var joaquim = new Pessoa();
            //Console.WriteLine("População = " + Pessoa.Populacao);

            //var pessoa1 = new Pessoa
            //{
            //    Nome = "Joaquim"
            //};

            //RH.Contratar(pessoa1, 1000);
            //Console.WriteLine("Joaquim agora tem salario"+ pessoa1.Salario);

            Console.Read();
        }
    }

    static class RH
    {
        public static void Contratar(Pessoa pessoa, int salario)
        {
            pessoa.Salario = salario;
            Console.WriteLine("contratado" + pessoa.Salario);
        }
    }


    //class Pessoa
    //{
    //    public int Idade; //NUNCA
    //    private string _nome;

    //    public string Nome
    //    {
    //        get { return _nome; }
    //        set { _nome = value; }
    //    }
    //}

    //static class cal (int a, int b)
    //{
    //int x = a+b;
    //}



    class Pessoa
    {
        public static int Populacao {get; private set;}
        public string Nome {get;set;}
        public int Idade { get; set; }
        public string Sobrenome { get; set; }
        public int Salario { get; set; }

        public Pessoa()
        {
            Nome = "Fulano";
            Populacao++;        
        }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Sobrenome = sobrenome; 
            Populacao++;
        }
    }
    
}




