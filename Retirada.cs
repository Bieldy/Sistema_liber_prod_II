using System;

namespace SIS_LIBERACAO_PRO_TWO
{
     public static class Ret  
       {
       
          public static void Retirada()
          {

                Console.WriteLine("Acesso liberado para coleta");
                Console.WriteLine("");
                Console.WriteLine("Preencha os campos a seguir ");
                Console.WriteLine("_____________________________");
                
                ItemRetirada();


                static void ItemRetirada()
                {
                    Console.WriteLine("Item de retirada: ");
                    Console.WriteLine("");                  
               
                    string item_prod = Console.ReadLine().Trim();

                    if(string.IsNullOrEmpty(item_prod))
                    { 
                      Console.WriteLine("Produto inválido, digite o nome do item:");
                      Console.WriteLine(" ");
                      ItemRetirada();
                    }
                  
                    else 
                    {
                    Console.WriteLine("");
                    Console.WriteLine("Digite código do produto:");
                    string cod_prod = Console.ReadLine().Trim();

                    int number_cod_prod;

                       if (int.TryParse(cod_prod, out number_cod_prod))
                       {
                        Console.Clear();
                        Console.WriteLine("Produto -> " + item_prod);
                        Console.WriteLine("Código: " + number_cod_prod);

                        Console.WriteLine("");

                        Console.WriteLine("Liberado para envio !!!");
                        Console.WriteLine(" ");
                          
                        
                       }

                       else
                       {
                          Console.Clear();
                          
                          ItemRetirada();
                        //System.Environment.Exit(0);
                        }

                    }
              }
          }

       }

}