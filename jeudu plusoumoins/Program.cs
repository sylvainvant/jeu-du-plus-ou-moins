using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudu_plusoumoins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nombreATrouve = new Random().Next(0, 100);
            int nombreTaper;
            string n;
            int nombreDeCoup=1;
            bool trouve = false;
            Console.WriteLine(nombreATrouve);
            Console.WriteLine("\t\t regles: du jeu nombre secret");
            Console.WriteLine("L'ordinateur calcul un nombre aléatoire et nous devons tenter de le deviner");
            Console.WriteLine("Il nous indique si le nombre saisi est plus grand ou plus petit que le nombre à trouver");
            Console.WriteLine("Une fois trouvé, il nous indique en combien de coups nous avons réussi à trouver le nombre secret.");
            //                                        debut 
            
              while (!trouve)
              {
                Console.WriteLine(" proposer un nombre :");
               n = Console.ReadLine();
                  if (int.TryParse(n, out nombreTaper))
                      {
                    if (nombreTaper == nombreATrouve)
                        trouve = true;
               else
            {
                if (nombreTaper < nombreATrouve)
                    Console.WriteLine("Trop petit ...");
                else
                    Console.WriteLine("Trop grand ...");
            }
                    nombreDeCoup++; 
                  }
            else
                Console.WriteLine("vous avez trouver en " );
                }
                Console.WriteLine(+nombreDeCoup+"nombre de coup");
                Console.ReadKey();
                     
              
               
            }

            }
        }


