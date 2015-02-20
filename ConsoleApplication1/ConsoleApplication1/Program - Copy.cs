using System;
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






//BASICOS
//var data = new DateTime(2015, 1, 1, 0, 0, 0);
//var outradata = data.AddYears(32);
//Console.WriteLine(outradata);
//Console.WriteLine(x);
//Console.WriteLine("Vai tricolor");
//Console.Read();



////FOREACH
////int[] meuArray = new int[10];

//var meuArray = new int[10];
//meuArray[0]= 1;

////var meuArray = new List<string>
////{
////    "a","b","c"
////};
//foreach (var item in meuArray)
//{
//    Console.WriteLine(item);
//}

////ARRAY DE MULTIPLAS DIMENSOES
//var array = new int[2, 2, 2];
////ARRAY DE ARRAYS
//int[][] jaggedArray = new int[3];

//// DO =! WHILE (executa pelo menos uma vez)


//MANIPULACAO DE TEXTO
//string teste = "qwerqwer";
//var watch = new Stopwatch();
//watch.Start();
//for (int i = 0; i < 100; i++)
//{
//    teste= teste +"asdfasdfasdf";
//}
//watch.Stop();
//Console.WriteLine(watch.Elapsed);
//Console.Read();

//string teste = "qwerqwer";
//var b = new StringBuilder();
//var watch = new Stopwatch();
//watch.Start();
//for ( int i = 0; i<100000; i ++)
//{
//    b.Append("asndfkasd");
//}
//teste = b.ToString();
//watch.Stop();
//Console.WriteLine(watch.Elapsed);
//Console.Read();

// SWITCH
//switch (x)
//{
//    case 1:
//        Console.WriteLine("X 1");
//        break;

//    case 2:
//        Console.WriteLine("X 2");
//        break;

//    default:
//        Console.WriteLine("asdfas");
//        break;
//}