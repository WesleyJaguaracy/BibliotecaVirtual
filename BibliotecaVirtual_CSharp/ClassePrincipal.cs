using System;
using System.Collections.Generic;

namespace BibliotecaVirtual
{
    class Principal
    {
        static void Main(string[] args)
        {
            List<Livros> livros = new List<Livros>();
            char verificador;
            bool check = true;
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
                        
                            /*for (int i = 0; i < livros.Count; i++)
                            {
                            Console.WriteLine(i + " - " + livros(i).GetTitulo() + 
                                "\n_________________________\n");
                            }*/
                        
                        break;
                        

                    
                }

            } while (true);
            
          
        }
    }
}