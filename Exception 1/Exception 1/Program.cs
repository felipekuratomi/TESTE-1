using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Adicionar(0, 0);
                //int x = 1;
                //int y = 0;

                //int z = x / y;
            }

            catch (DivideByZeroException ex)
            {
               // Console.WriteLine(ex.Message);
                Debug.WriteLine(ex.Message);
            }
            catch (FileNotFoundException)
            {
                Debug.WriteLine("FIle nao encontrado ");

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

            }

            finally 
            {  
               // Console.Read();
            }


        }
        static int Adicionar(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                throw new ArgumentException("x e y tem que ser maior q 0");
            }

            return x + y;
        }



    }
}
