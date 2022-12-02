using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaVirtual
{
    internal class NewBaseType
    {
        private String nome;
        private String sobrenome;
        private String email;

        public string getEmail()
        {
            return email;
        }

        public string getNome()
        {
            return nome;
        }

        public string getSobrenome()
        {
            return sobrenome;
        }

        //Scanner teclado = new Scanner(System.in);

        public void lerAutor()
        {
            Console.Write("Digite o primeiro nome do autor: ");
            //this.setNome(teclado.nextLine());

            Console.Write("Digite o sobrenome do autor: ");
            //this.setSobrenome(teclado.nextLine());

            Console.Write("Digite o email do autor: ");
            //this.setEmail(teclado.nextLine());

        }

        public void setEmail(string email)
        {
            this.email = verificaEmail(email);
        }

        public void setNome(string nome)
        {
            this.nome = verificaChar(nome);
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = verificaChar(sobrenome);
        }
        public string toString()
        {
            return "" + nome + " " + sobrenome + "";
        }

        public string verificaChar(string nome)
        {
            bool x;
            char a;

            do
            {
                x = true;

                for (int i = 0; i < nome.length(); i++)
                {
                    a = nome.charAt(i);
                    int b = a;
                    if (b == 32 || b >= 65 && b <= 90 || b >= 97 && b <= 122)
                    {
                    }
                    else
                    {
                        x = false;
                    }
                }
                if (!x)
                {
                    Console.Write("Nome inválido\nInforme um nome/sobrenome apenas com letras");
                    //nome = teclado.nextLine();
                }
            } while (!x);
            return nome;
        }
        public string verificaEmail(string email)
        {
            bool x;
            char a;

            do
            {
                x = true;

                for (int i = 0; i < email.length(); i++)
                {
                    a = email.charAt(i);
                    int b = a;
                    if (b == 64)
                    {
                        x = false;
                    }
                }
                if (x)
                {
                    Console.Write("Email inválido\nInforme um email válido");
                    //email = teclado.nextLine();
                }
            } while (x);
            return email;
        }
    }

    class Autor : NewBaseType
    {
        @Override
    }