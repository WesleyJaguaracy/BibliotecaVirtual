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
            bool bool1 = true;
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
                                    var v = livros.Remove(check);

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

                            do
                            {
                                Console.WriteLine("\n\tDeseja pesquisar livros pelo: " +
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
                                            else
                                            {
                                                Console.WriteLine("Nenhum livro cadastrado com esse título");
                                            }
                                        }

                                        break;

                                    case '2':
                                        Livros buscarAutor = new Livros();
                                        Autor autor = new Autor();
                                        Console.WriteLine("Digite o nome do autor do livro a ser procurando: ");
                                        Console.ReadLine();
                                        autor.SetNome(Console.ReadLine());
                                        Console.WriteLine("Digite o sobrenome do autor do livro a ser procurado: ");
                                        autor.SetSobrenome(Console.ReadLine());
                                        buscarAutor.SetAutor(autor);
                                        for (int j = 0; j < livros.Count(); j++)
                                        {
                                            if ((buscarAutor.GetAutor().GetNome().Equals(livros.Count(j).GetAutor().GetNome())) && (buscarAutor.GetAutor().GetSobrenome().GetNome().Equals(livros.Count(j).GetAutor().GetSobrenome())))
                                            {
                                                Console.WriteLine("");
                                            }
                                            else
                                            {

                                            }
                                        }

                                        Livros.enterToContinue();
                                        break;

                                    case '3':
                                        Livros buscarEditora = new Livros();
                                        Editora editora = new Editora();
                                        Console.WriteLine("Digite o nome da editora do livro a ser procurado: ");
                                        Console.ReadLine();
                                        editora.SetNome(Console.ReadLine());
                                        buscarEditora.GetEditora(editora);
                                        for (int j = 0; j < livros.Count(); j++)
                                        {
                                            if (buscarEditora.GetEditora().GetNome().Equals(livros.Count(j).GetEditora().GetNome()))
                                            {
                                                Console.WriteLine(livros.Count(j).ToString());
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nenhum livro cadastrado com essa editora");
                                            }
                                        }
                                        Livros.enterToContinue();

                                        break;

                                    case '4':
                                        booleano = false;

                                        break;

                                    default:

                                        break;
                                }

                            } while (booleano);

                        } 
                        else
                        {
                            Console.WriteLine("Tente cadastrar algo antes de procurar!");
                            Livros.enterToContinue();
                        }

                        break;

                    case '5':
                        bool1 = false;

                        break;

                    default:
                        Console.WriteLine("Entrada inválida, tente novamente!");
                        Livros.enterToContinue();

                        break;
                }

            } while (bool1);

            Console.WriteLine("Sistema finalizado!");
        }
    }
}