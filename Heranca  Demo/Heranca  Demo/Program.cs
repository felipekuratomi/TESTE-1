using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca__Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var c = new Cachorro();
            //c.Nome = "Fido";
            //c.Andar();
            CuidadorDeAnimais.LevarParaPassear(c);

            var g = new Gato();
            CuidadorDeAnimais.LevarParaPassear(g);
            Console.Read();
        }
    }
    abstract class Animal
    {
        public abstract void Falar();

        public string Nome { get; set; }
        public virtual void Andar()
        {
            Console.WriteLine("Animal andando");
        
        }

    }

    class CuidadorDeAnimais
    {
        public static void LevarParaPassear(Animal animal)
        {
            animal.Andar();
        }
        
    }




    sealed class Cachorro : Animal
    {
        public override void Andar()
        {
            base.Andar();
            Console.WriteLine("Cachorro andando");
        }
        public override void Falar()
        {
            throw new NotImplementedException();
        }
        
    
    }
    sealed class Gato : Animal
    {
        public override void Andar()
        {
            Console.WriteLine("Gato andando");
        }
        public override void Falar()
        {
            throw new NotImplementedException();
        }
        
    }


}
