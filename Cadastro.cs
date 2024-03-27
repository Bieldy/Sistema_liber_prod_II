using System;

namespace SIS_LIBERACAO_PRO_TWO
{
     public static class Cad  
      {
       
          public static void Cadastro()
        {
            Console.Clear();
            New_name();
            New_password();
            New_data_nasc();
            
        }
         
              public static void New_name()
              {
                Console.WriteLine("Cadastre nome de usuário");
                string user = Console.ReadLine().Trim();

                   if (string.IsNullOrEmpty(user))
                    {  
                       Console.Clear();
                       Console.WriteLine("Por favor, digite pelo menos um caractere.");
                       New_name();
                    }

                  else 
                   {                  
                        Console.Clear();
                        New_password();
                   }  

               }  

                  public static void New_password()
               {    
                      Console.WriteLine("Cadastre a senha");

                      string password = Console.ReadLine().Trim();//Comando Trim é usado para remover os caracteres em branco (espaços em branco, tabulações, quebras de linha etc.) do início e do final de uma string. Ele retorna uma nova string com os caracteres em branco removidos.

                     if (string.IsNullOrEmpty(password))
                      {
                        Console.Clear();
                        Console.WriteLine("Por favor, digite pelo menos um caractere.");
                        New_password();
                      }

                     else 
                      { 
                        Console.Clear();
                        New_data_nasc();
                      }
                }      
                
              static void New_data_nasc()
               {                       
                          Console.WriteLine("Cadastre a data de Nascimento:");
                          Console.WriteLine(" ");
                          string Data_nasc = Console.ReadLine().Trim();

                          int data_nasc;
                           
                            if (int.TryParse(Data_nasc, out data_nasc)) 
                             {
                                Console.Clear();
                                Log.Login();
                             }
                
                            else 
                             {
                                Console.Clear();
                                Console.WriteLine("Data Inválida!");
                                

                                New_data_nasc();
                             }

                }     
                    
       }
 }
