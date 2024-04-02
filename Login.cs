using System;

namespace SIS_LIBERACAO_PRO_TWO
{
     public static class Log  
      {
       
              public static void Login()
               {
                  Console.Clear();
                  User_cadastrado();
                     
               }
               
                  public static void User_cadastrado()
                  {
                     Console.WriteLine("Cadastro Feito com sucesso");
                     Console.WriteLine("   ");
                     Console.WriteLine(" FAÇA O LOGIN ");
                     Console.WriteLine("   ");
                   
                     Console.WriteLine("Informe o nome de Usuário:");
                     Console.WriteLine(" ");
                     string user_cad = Console.ReadLine().Trim();

                        if (string.IsNullOrEmpty(user_cad))
                          {
                             Console.Clear();
                             Console.WriteLine("Usuário inválido!");
                             User_cadastrado();
                          }

                        else 
                          { 
                             Console.WriteLine(" ");
                             Console.WriteLine("Informe a senha cadastrada:");
                             string password_cad = Console.ReadLine().Trim();

                                if (string.IsNullOrEmpty(password_cad))
                                {
                                    Console.WriteLine("Senha inválida");
                                    User_cadastrado();
                                }

                                else 
                                  {
                                     Console.Clear();
                                     Console.WriteLine("Bem-vindo ");
                                     Console.WriteLine("");
                                     Ret.Retirada();
                                   }
                          }
                             
                  }
             
                             
       }
}
