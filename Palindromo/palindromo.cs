using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            
            Console.WriteLine("Digite a frase ou uma palavra a ser verificada: ");

            //a string palavra será preenchida com o que for digitado
            palavra = Console.ReadLine();

            //a variável x receberá o tamanho de palavra -1
            int x = palavra.Length - 1; // comparar dentro da mesma estrutura de posições da mesma estrutura de indices da string que começa em 0

            //enquanto x for diferente de -1
            while (x != -1) //while repete enquanto a codição for verdadeira
            {
                //variável i começa com 0, para i < tamanho palavra, i recebe +1
                for (int i = 0; i < palavra.Length; i++) //será até o tamanho da palavra
                {
                    //se o conteúdo da string na posição i
                    //for igual ao da posição
                    if (palavra[i] == palavra[x])
                    {
                        //se x = 0 terminou a comparação e todas as posições foram 
                        //iguais
                        if (x == 0)
                        {
                            Console.WriteLine("É um palíndromo!");
                            Console.WriteLine();
                        }
                        //subtrai 1 de x
                        x--;
                    }
                    else
                    {
                        Console.WriteLine("Não é um palíndromo!");
                        //variavel i recebe o valor do tamanho da string 
                        i = palavra.Length; //variaveis de controle do programa
                        x = -1;     //variaveis de controle do programa

                        //espera uma tecla para finalizar
                        Console.WriteLine();
                    }


                }
            }
        }
    }
}
