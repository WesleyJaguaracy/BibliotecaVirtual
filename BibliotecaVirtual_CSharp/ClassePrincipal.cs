using System;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaVirtual
{
    class Principal
    {
        static void Main(string[] args)
        {
            List<Livros> livros = new List<Livros>();
            char verificador;
            char variavel;
            bool boole = true;
            bool teste = true;            

            do
            {
                int totalDeTitulos = Livros.GetTotalDeTitulos();
                int totalDeExemplares = Livros.GetTotalDeExemplares();

                Console.WriteLine(totalDeTitulos + " TÍTULOS CADASTRADOS\n" +
                                  totalDeExemplares + " EXEMPLARES CADASTRADOS" +
                                  "\n\t_________________________" +
                                  "\n\t|\t1 - CADASTRAR LIVRO\t|" +
                                  "\n\t|\t2 - REMOVER LIVRO\t|" +
                                  "\n\t|\t3 - EDITAR LIVRO\t|" +
                                  "\n\t|\t4 - PESQUISAR LIVRO\t|" +
                                  "\n\t|\t5 - SAIR\t\t|" +
                                  "\n\t_________________________");
                var textoDigitado = Console.ReadLine();
                verificador = textoDigitado[0];

                switch (verificador)
                {
                    case '1':
                        Livros a = new Livros();

                        a.CadastrarLivros();

                        livros.Add(a);
                        break;


                    case '2':

                            if (livros.Count() > 0)
                            {
                                for (int i = 0; i < livros.Count(); i++)
                                {
                                    Console.WriteLine(i + " - " + livros[i].GetTitulo() + "\n_________________________\n");
                                }

                                int cont = 0;

                            do
                            {
                                try
                                {
                                    Console.WriteLine("Insira o código do livro a ser deletado: ");
                                    if (cont != 0) 
                                    {
                                        Console.ReadLine();
                                    }
                                        int check = int.Parse(Console.ReadLine());
                                        Livros.SetTotalDeTitulos(totalDeTitulos - 1);
                                        Livros.SetTotalDeExemplares(totalDeExemplares - livros.Count(check).NumeroExemplares());
                                        livros.Remove(check);

                                        Console.WriteLine("Livri excluido com êxito!");
                                        Livros.enterToContinue();

                                        teste = false;
                                    
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Caracter inválido!");
                                    teste = true;
                                    cont++;
                                }

                            } while (teste);
                            } 
                            else
                            {
                                Console.WriteLine("Tente cadastrar algo antes de exluir!");
                                Livros.enterToContinue();
                            }

                        break;

                    case '3':
                        if (livros.Count() > 0)
                        {
                            for (int i = 0; i < livros.Count(); i++)
                            {
                                Console.WriteLine(i + " - " + livros[i].GetTitulo() + "\n_________________________\n");
                            }

                            int cont = 0;

                            do
                            {
                                try
                                {
                                    Console.WriteLine("Insira o codigo do livro a ser editado: ");
                                    if (cont != 0)
                                    {
                                        Console.ReadLine();
                                    }
                                    int check = int.Parse(Console.ReadLine());
                                    Livros.SetTotalDeTitulos(totalDeTitulos - 1);
                                    Livros.SetTotalDeExemplares(totalDeExemplares - livros.Count(check).NumeroExemplares());
                                    livros.Remove(check);

                                    Livros b = new Livros();

                                    b.CadastrarLivros();

                                    livros.Add(b);

                                    Console.WriteLine("Livros editado com êxito: ");
                                    Livros.enterToContinue();

                                    teste = false;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Caracter inválido!");
                                    teste = true;
                                    cont++;
                                }
                            } while (teste);

                        } 
                        else
                        {
                            Console.WriteLine("Tente cadastrar algo antes de editar!");
                            Livros.enterToContinue();
                        }

                        break;

                    case '4':
                        if (livros.Count() > 0)
                        {
                            
                            bool booleano = true;
                        }
                        do
                        {
                            Console.WriteLine("\n\tDeseja pesquisar livros pelo: "+
                                        "\n\t___________________" +
                                        "\n\t|\t1 - TÍTULO\t\t|" +
                                        "\n\t|\t2 - AUTOR\t\t|" +
                                        "\n\t|t3 - EDITORA\t\t|" +
                                        "\n\t|t4 - SAIR\t\t|" +
                                        "\n\t_____________________");
                            var varDigitado = Console.ReadLine();
                            variavel = varDigitado[0];

                            switch (variavel)
                            {
                                case '1':
                                    Livros buscaTitulo = new Livros();
                                    Console.WriteLine("Digite o título do livro a ser procurado: ");
                                    Console.ReadLine();
                                    buscaTitulo.SetTitulo(Console.ReadLine());
                                    for (int j = 0; j < Livros.cont; j++)
                                    {
                                        if (buscaTitulo.GetTitulo().Equals(livros.Count(j).GetTitulo()))
                                        {
                                            Console.WriteLine();
                                            Livros.enterToContinue();
                                        }
                                    }

                                    break;
                            }

                        } while (true);

                        break;

                }

            } while (boole);

            Console.WriteLine("Sistema finalizado!");
        }
    }
}