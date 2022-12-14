using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaVirtual
{
    class Livros
    {
        public bool teste = true;
        public static int cont = 0;
        public static int cont1 = 0;

        private static int totalDeTitulos = 0;
        private static int totalDeExemplares = 0;

        private string titulo { get; set; }
        private Editora editora { get; set; }
        private Autor autor { get; set; }
        private int numeroPags { get; set; }
        private int numeroExemplares { get; set; }

        public static int GetTotalDeTitulos()
        {
            return Livros.totalDeTitulos;
        }

        public static void SetTotalDeTitulos(int totalDeTitulos)
        {
            Livros.totalDeTitulos = totalDeTitulos;
        }

        public static int GetTotalDeExemplares()
        {
            return Livros.totalDeExemplares;
        }

        public static void SetTotalDeExemplares(int totalDeExemplares)
        {
            Livros.totalDeExemplares = totalDeExemplares;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public void SetTitulo(string titulo)
        {
            this.titulo = checaTitulo(titulo);
        }

        public Editora GetEditora()
        {
            return editora;
        }
        public void GetEditora(Editora editora)
        {
            this.editora = editora;
        }
        public Autor GetAutor()
        {
            return autor;
        }
        public void SetAutor(Autor autor)
        {
            this.autor = autor;
        }
        public int GetNumeroExemplares()
        {
            return numeroExemplares;
        }
        public void SetNumeroExemplares(int numeroExemplares)
        {
            this.numeroExemplares = numeroExemplares;
        }
        public int GetNumeroPags()
        {
            return numeroPags;
        }
        public void SetNumeroPags(int numeroPags)
        {
            this.numeroPags = numeroPags;
        }
        public void CadastrarLivros()
        {
            Console.Write("Digite o título do livro: ");
            titulo = Console.ReadLine();

            do
            {
                try
                {
                    Console.Write("Digite o número de páginas: ");
                    numeroPags = int.Parse(Console.ReadLine());
                    
                    if (cont != 0)
                    {
                        Console.Read();
                    }
                    this.GetNumeroPags();

                    teste = false;
                }
                catch (Exception)
                {
                    Console.Write("Caracter inválido");
                    teste = true;
                    cont++;
                }
            } while (teste);

            do
            {
                try
                {
                    Console.Write("Digite o número de exemplares: ");
                    numeroExemplares = Console.Read();
                    if (cont != 0)
                    {
                        numeroExemplares = int.Parse(Console.ReadLine());
                    }

                    this.GetNumeroExemplares();

                    teste = false;
                }
                catch (Exception)
                {
                    Console.Write("Caracter inválido!");
                    teste = true;
                    cont++;
                }
            } while (teste);

            Editora e = new Editora();

            e.lerEditora();
            this.GetEditora(e);

            Autor a = new Autor();

            a.lerAutor();
            this.SetAutor(a);

            Console.Write("Cadastro completo!\n");
            Livros.totalDeTitulos = Livros.totalDeTitulos + 1;
            Livros.totalDeExemplares = Livros.totalDeExemplares + this.GetNumeroExemplares();
            enterToContinue();
        }


        public static void enterToContinue()
        {
            Console.WriteLine("Aperte enter para Continuar...");
            try
            {
                Console.ReadLine();
            }
            catch (Exception)
            {

            }
        }

        public string toString()
        {
            return "Titulo: " + titulo +
                  "\nEditora: " + editora +
                  "\nAutor: " + autor +
                  "\nNumero de paginas: " + numeroPags +
                  "\nNumero de exemplares: " + numeroExemplares +
                  '\n';
        }

        public Livros(string titulo)
        {
            this.titulo = titulo;
        }

        public Livros()
        {

        }
        public string checaTitulo(string titulo)
        {
            bool check = true;

            do
            {
                if (titulo.Length >= 5)
                {
                    check = false;
                }
                if (check)
                {
                    Console.Write("O título deve ter no mínimo 5 caracteres\n Digite o título do livro: ");
                    Console.ReadLine();
                }

            } while (check);

            return titulo;
        }
    }
}