using System;
using System.IO;

namespace CaminhaFisicoTxt
{
    class LeitorTxt
    {
        static void Main(string[] args)       
        {        

        Console.WriteLine("Qual o caminho físico do arquivo?");
            string caminhoDigitado = Console.ReadLine(); //Passa o caminho atraves da variavel caminhoDigitado.

        string exibirCaminho = File.ReadAllText(caminhoDigitado); //ReadAllText -> Abre o arquivo de texto, lê todo arquivo.
            Console.WriteLine(exibirCaminho);


        }
    }
}
