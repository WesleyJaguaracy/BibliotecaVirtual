using System;

namespace Livros
{
    class Principal
    {
        static void Main(string[] args)
        {
            ArrayList<Livros> L = new ArrayList<>();
            char verificador;            
            bool teste = true;

            //Scanner teclado = new Scanner(System.in);

            do
            {
                int totalDeTitulos = Livros.getTotalDeTitulos();
                int totalDeExemplares = Livros.getTotalDeExemplares();
                Console.Write(totalDeTitulos + " TÍTULOS CADASTRADOS\n" +
                        totalDeExemplares + " EXEMPLARES CADASTRADOS" +
                        "\n\t_________" +
                        "\n\t|\t1 - CADASTRAR LIVRO\t|" +
                        "\n\t|\t2 - REMOVER LIVRO\t|" +
                        "\n\t|\t3 - EDITAR LIVRO\t|" +
                        "\n\t|\t4 - PESQUISAR LIVRO\t|" +
                        "\n\t|\t5 - SAIR\t\t|" +
                        "\n\t_________");
                verificador = teclado.next().charAt(0);

                switch (verificador)
                {
                    case '1':
                        Livros a = new Livros();

                        a.cadastraLivros();

                        L.add(a);
                        break;

                    case '2':
                        if (L.size() > 0)
                        {
                            for (int i = 0; i < L.size(); i++)
                            {
                                Console.Write(i + " - " + L.get(i).getTitulo() + "\n_____________\n");
                            }

                            int cont = 0;

                            do
                            {
                                try
                                {
                                    Console.Write("Insira o código do livro a ser deletado:");
                                    if (cont != 0)
                                    {
                                        teclado.next();
                                    }
                                    int check = teclado.nextInt();
                                    Livros.setTotalDeTitulos(totalDeTitulos - 1);
                                    Livros.setTotalDeExemplares(totalDeExemplares - L.get(check).getNumeroExemplares());
                                    L.remove(check);

                                    Console.Write("Livro excluído com êxito!");
                                    Livros.enterToContinue();

                                    teste = false;
                                }
                                catch (Exception e)
                                {
                                    Console.Write("Caracter inválido!");
                                    teste = true;
                                    cont++;
                                }
                            } while (teste);
                        }
                        else
                        {
                            Console.Write("Tente cadastrar algo antes de excluir!");
                            Livros.enterToContinue();
                        }

                        break;

                    case '3':
                        if (L.size() > 0)
                        {
                            for (int i = 0; i < L.size(); i++)
                            {
                                Console.Write(i + " - " + L.get(i).getTitulo() + "\n_____________\n");
                            }

                            int cont = 0;

                            do
                            {
                                try
                                {
                                    Console.Write("Insira o código do livro a ser editado:");
                                    if (cont != 0)
                                    {
                                        teclado.next();
                                    }
                                    int check = teclado.nextInt();
                                    Livros.setTotalDeTitulos(totalDeTitulos - 1);
                                    Livros.setTotalDeExemplares(totalDeExemplares - L.get(check).getNumeroExemplares());
                                    L.remove(check);

                                    Livros b = new Livros();

                                    b.cadastraLivros();

                                    L.add(b);

                                    Console.Write("Livro editado com êxito!");
                                    Livros.enterToContinue();

                                    teste = false;
                                }
                                catch (Exception e)
                                {
                                    Console.Write("Caracter inválido!");
                                    teste = true;
                                    cont++;
                                }
                            } while (teste);
                        }
                        else
                        {
                            Console.Write("Tente cadastrar algo antes de editar!");
                            Livros.enterToContinue();
                        }

                        break;

                    case '4':
                        if (L.size() > 0)
                        {
                            char variavel;
                            bool boleano = true;

                            do
                            {
                                Console.Write("\n\tDeseja pesquisar livros pelo:" +
                                        "\n\t_________" +
                                        "\n\t|\t1 - TÍTULO\t\t|" +
                                        "\n\t|\t2 - AUTOR\t\t|" +
                                        "\n\t|\t3 - EDITORA\t\t|" +
                                        "\n\t|\t4 - SAIR\t\t|" +
                                        "\n\t_________");
                                variavel = teclado.next().charAt(0);

                                switch (variavel)
                                {
                                    case '1':
                                        Livros buscaTitulo = new Livros();
                                        Console.Write("Digite o título do livro a ser procurado: ");
                                        teclado.nextLine();
                                        buscaTitulo.setTitulo(teclado.nextLine());
                                        for (int j = 0; j < L.size(); j++)
                                        {
                                            if (buscaTitulo.getTitulo().equals(L.get(j).getTitulo()))
                                            {
                                                Console.Write(L.get(j).toString());
                                                Livros.enterToContinue();
                                            }
                                            else
                                            {
                                                Console.Write("Nenhum livro cadastrado com esse título");
                                            }
                                        }
                                        break;

                                    case '2':
                                        Livros buscaAutor = new Livros();
                                        Autor autor = new Autor();
                                        Console.Write("Digite o nome do autor do livro a ser procurado: ");
                                        teclado.nextLine();
                                        autor.setNome(teclado.nextLine());
                                        Console.Write("Digite o sobrenome do autor do livro a ser procurado: ");
                                        autor.setSobrenome(teclado.nextLine());
                                        buscaAutor.setAutor(autor);
                                        for (int j = 0; j < L.size(); j++)
                                        {
                                            if (buscaAutor.getAutor().getNome().equals(L.get(j).getAutor().getNome()) && buscaAutor.getAutor().getSobrenome().equals(L.get(j).getAutor().getSobrenome()))
                                            {
                                                Console.Write(L.get(j).toString());
                                            }
                                            else
                                            {
                                                Console.Write("Nenhum livro cadastrado com esse autor");
                                            }
                                        }

                                        Livros.enterToContinue();
                                        break;

                                    case '3':
                                        Livros buscaEditora = new Livros();
                                        Editora editora = new Editora();
                                        Console.Write("Digite o nome da editora do livro a ser procurado: ");
                                        teclado.nextLine();
                                        editora.setNome(teclado.nextLine());
                                        buscaEditora.setEditora(editora);
                                        for (int j = 0; j < L.size(); j++)
                                        {
                                            if (buscaEditora.getEditora().getNome().equals(L.get(j).getEditora().getNome()))
                                            {
                                                Console.Write(L.get(j).toString());
                                            }
                                            else
                                            {
                                                Console.Write("Nenhum livro cadastrado com essa editora");
                                            }
                                        }
                                        Livros.enterToContinue();
                                        break;

                                    case '4':
                                        boleano = false;

                                        break;

                                    default:

                                        break;
                                }
                            } while (boleano);
                        }
                        else
                        {
                            Console.Write("Tente cadastrar algo antes de procurar!");
                            Livros.enterToContinue();
                        }


                        break;

                    case '5':
                        bool = false;

                        break;

                    default:
                        Console.Write("Entrada invalida, tente novamente!");
                        Livros.enterToContinue();



                        break;
                }
            } while (bool);

            Console.Write("Sistema finalizado!");
        }
    }
}