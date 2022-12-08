using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaVirtual
{
    class Editora
    {
        private string nomeSolicitante { get; set; }
        private string endereco { get; set; }
        private string email { get; set; }

        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = VerificaEmail(email);
        }
        public string GetEndereco()
        {
            return endereco;
        }
        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string GetNome()
        {
            return nomeSolicitante;
        }
        public void SetNome(string nome)
        {
            this.nomeSolicitante = nome;
        }

        public void lerEditora()
        {
            Console.WriteLine("Digite o nome da editora: ");
            Console.ReadLine();

            Console.WriteLine("Digite o endereço da editora: ");
            Console.ReadLine();

            Console.WriteLine("Digite o email da editora: ");
            Console.ReadLine();
        }


        public string VerificaEmail(string email)
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
                    Console.WriteLine("Email inválido\n Informe um email válido");
                    Console.ReadLine();
                }
            } while (x);
            return email;
        }

        public string toString()
        {
            return "" + nomeSolicitante + "";
        }
    }
}