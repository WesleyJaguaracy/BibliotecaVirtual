using System;
using System.IO;

namespace CaminhaFisico
{
    class Program
    {
        static void Main(string[] args)        {
            

        Console.WriteLine("Qual o caminho físico do arquivo?");
        string text = Console.ReadLine();
            string text2 = @"C:\Users\Wesle\OneDrive\Documentos\Times.txt";

            if (string.Equals(text, text2))
            {
                text2 = System.IO.File.ReadAllText(@"C:\Users\Wesle\OneDrive\Documentos\Times.txt");
                Console.WriteLine(text2);
            }
            else
            {
                Console.WriteLine("Não existe!");
            }                       

        }
    }
}
