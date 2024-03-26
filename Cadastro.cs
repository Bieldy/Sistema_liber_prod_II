using System;

namespace SIS_LIBERACAO_PRO_TWO
{
     public static class Cad  
       {
       
          public static void Cadastro()
        {
            Console.Clear();
            Console.WriteLine("Insira o nome de usuário");
            string user = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(user))
            {
                Console.WriteLine("Por favor, digite pelo menos um caractere.");
                Cadastro();
            }

            Console.WriteLine("Digite a senha (apenas números)");

             string password = Console.ReadLine().Trim();//Comando Trim é usado para remover os caracteres em branco (espaços em branco, tabulações, quebras de linha etc.) do início e do final de uma string. Ele retorna uma nova string com os caracteres em branco removidos.

            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Por favor, digite pelo menos um caractere.");
                Cadastro();
            }

            else
            {
                string acess = user + password;

                if (user + password == acess)
                {
                    Console.Clear();
                    Console.WriteLine("Cadastro feito com sucesso!");
                    Console.WriteLine("");
                    Console.WriteLine("Seja Bem-vindo " + user);
                    Console.WriteLine("___________________________");
                }

                string Acess = acess;
            }

        }
    }
}