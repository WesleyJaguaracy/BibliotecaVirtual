using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaVirtual
{
    class Autor
    {
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private string Email { get; set; }

        public String GetNome()
        {
            return Nome;
        }

        public void SetNome(String nome)
        {
            this.Nome = verificaChar(nome);
        }

        public String GetSobrenome()
        {
            return Sobrenome;
        }

        public void SetSobrenome(String sobrenome)
        {
            this.Sobrenome = verificaChar(sobrenome);
        }

        public String GetEmail()
        {
            return Email;
        }

        public void SetEmail(String email)
        {
            this.Email = verificaEmail(email);
        }

        public void lerAutor()
        {
            Console.Write("Digite o primeiro nome do autor: ");
            Console.ReadLine();

            Console.Write("Digite o sobrenome do autor: ");
            Console.ReadLine();

            Console.Write("Digite o email do autor: ");
            Console.ReadLine();
        }

        public string verificaChar(string nome)
        {
            bool x;
            char a;

            do
            {
                x = true;

                for (int i = 0; i < nome.Length; i++)
                {
                    a = nome[i];
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
                    Console.Write("Nome inválido\n Informe um nome/sobrenome apenas com letras");
                    Console.ReadLine();
                }
            } while (!x);
            return nome;
        }

        public string verificaEmail(String email)
        {
            bool x;
            char a;

            do
            {
                x = true;

                for (int i = 0; i < email.Length; i++)
                {
                    a = email[i];
                    int b = a;
                    if (b == 64)
                    {
                        x = false;
                    }
                }
                if (x)
                {
                    Console.Write("Email inválido\n Informe um email válido");
                    Console.ReadLine();
                }
            } while (x);
            return email;
        }

        public string toString()
        {
            return "" + Nome + "" + Sobrenome + "";
        }
    }
}