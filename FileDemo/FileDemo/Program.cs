using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "asdfafsdfasdfas";
            string caminho = @"E:\arquivo.txt";  // \ ou @ Caracteres especiais dentro da string
            //File.WriteAllText(caminho,texto); // passar o caminho e o texto em si

            //string textoLido = File.ReadAllText(caminho);

            //string[] linhas = File.ReadAllLines(caminho);

            //var arquivo = new FileInfo(caminho);
            //if (arquivo.Exists)
            //{
            //    arquivo.Delete();
            //}

            //Directory.CreateDirectory(@"E:\Minha Pasta");
            //var arquivos = Directory.GetFiles(@"E:\Minha Pasta");
            //DirectoryInfo pasta = new DirectoryInfo(@"D:\Minha Pasta");

            string pasta = @"E:\ Pasta";
            string arquivo = "arquivo.txt";
            var caminhoCompleto = Path.Combine(pasta, arquivo);
            var temp = Path.GetTempPath();


        }
    }
}
