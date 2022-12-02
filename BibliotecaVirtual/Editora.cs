using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaVirtual
{
    class Editora
    { 
    private static int cont = 0;
    private static int cont1 = 0;
    private static bool teste = true;

    private static int totalDeTitulos = 0;
    private static int totalDeExemplares = 0;

    private String titulo;
    private Editora editora;
    private Autor autor;
    private int numeroPags;
    private int numeroExemplares;

    //Scanner teclado = new Scanner(System.in);


    public void cadastraLivros()
    {
        //System.out.println("Digite o título do livro: ");
        //this.setTitulo(teclado.nextLine());
            Console.Write("Digite o título do livro: ");

        do
        {
            try
            {
                    Console.Write("Digite o número de páginas: ");
                if (cont != 0)
                {
                    teclado.next();
                }
                this.setNumeroPags(teclado.nextInt());

                teste = false;
            }
            catch (Exception e)
            {
                    Console.Write("Caracter inválido!");
                teste = true;
                cont++;
            }
        } while (teste);

        do
        {
            try
            {
                    Console.Write("Digite o numero de exemplares: ");
                if (cont1 != 0)
                {
                    teclado.next();
                }
                this.setNumeroExemplares(teclado.nextInt());

                teste = false;
            }
            catch (Exception e)
            {
                    Console.Write("Caracter inválido!");
                    teste = true;
                    cont1++;
            }
        } while (teste);

        Editora e = new Editora();

        e.lerEditora();
        this.setEditora(e);

        Autor a = new Autor();

        a.lerAutor();
        this.setAutor(a);

            Console.Write("Cadastro completo!\n");
            Livros.totalDeTitulos = Livros.totalDeTitulos + 1;
            Livros.totalDeExemplares = Livros.totalDeExemplares + this.getNumeroExemplares();
            enterToContinue();
    }

        internal void lerEditora()
        {
            throw new NotImplementedException();
        }

        public static int getTotalDeTitulos()
    {
        return Livros.totalDeTitulos;
    }

    public static void setTotalDeTitulos(int totalDeTitulos)
    {
        Livros.totalDeTitulos = totalDeTitulos;
    }

    public static int getTotalDeExemplares()
    {
        return Livros.totalDeExemplares;
    }

    public static void setTotalDeExemplares(int totalDeExemplares)
    {
        Livros.totalDeExemplares = totalDeExemplares;
    }

    public String getTitulo()
    {
        return titulo;
    }

    public void setTitulo(String titulo)
    {
        this.titulo = checaTitulo(titulo);
    }

    public Editora getEditora()
    {
        return editora;
    }

    public void setEditora(Editora editora)
    {
        this.editora = editora;
    }

    public Autor getAutor()
    {
        return autor;
    }

    public void setAutor(Autor autor)
    {
        this.autor = autor;
    }

    public int getNumeroPags()
    {
        return numeroPags;
    }

    public void setNumeroPags(int numeroPags)
    {
        this.numeroPags = numeroPags;
    }

    public int getNumeroExemplares()
    {
        return numeroExemplares;
    }

    public void setNumeroExemplares(int numeroExemplares)
    {
        this.numeroExemplares = numeroExemplares;
    }

    public static void enterToContinue()
    {
            Console.Write("Aperte enter para continuar...");
        try
        {
            System.in.read();
        }
        catch (Exception e)
        { }
    }

    @Override
    public string toString() => "Titulo : " + titulo +
                "\nEditora : " + editora +
                "\nAutor : " + autor +
                "\nNumero de paginas : " + numeroPags +
                "\nNumero de exemplares : " + numeroExemplares +
                '\n';

        @Override
    public bool equals(Object o)
    {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Livros livros = (Livros)o;

        if (getNumeroPags() != livros.getNumeroPags()) return false;
        if (getNumeroExemplares() != livros.getNumeroExemplares()) return false;
        if (!getTitulo().equals(livros.getTitulo())) return false;
        if (!getEditora().equals(livros.getEditora())) return false;
        return getAutor().equals(livros.getAutor());

    }

    public Livros(String titulo)
    {
        this.titulo = titulo;
    }

    public Livros()
    {
    }

    public String checaTitulo(String titulo)
    {
        bool check = true;

        do
        {
            if (titulo.length() >= 5)
            {
                check = false;
            }
            if (check)
            {
                Console.Write("O título deve ter no mínimo 5 caracteres\nDigite o título do livro: ");
                //titulo = teclado.nextLine();
            }
        } while (check);

        return titulo;
    }
}