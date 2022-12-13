using System;
using System.Collections.Generic;

namespace Bridge
{
    class CImplementation2:IBridge
    {
        public void ShowTotalImp(Dictionary<string, double> pProd)
        {
            double total = 0;
            double totalA = 0;
            double totalP = 0;
            double totalZ = 0;
            int amount = 0;

            foreach(KeyValuePair<string, double> p in pProd){
                total += p.Value;
                switch(p.Key[0]){
                    case 'A':
                        totalA += p.Value;
                        break;
                    case 'P':
                        totalP += p.Value;
                        break;
                    case 'Z':
                        totalZ += p.Value;
                        break;
                    default:
                        break;
                }
                amount++;
            }
            Console.WriteLine("Total of A is {0}$", totalA);
            Console.WriteLine("Total of P is {0}$", totalP);
            Console.WriteLine("Total of Z is {0}$", totalZ);
            Console.WriteLine("Total of {0} products is {1}$", amount, total);
        }

        public void ListTotalImp(Dictionary<string, double> pProd)
        {
            foreach(KeyValuePair<string, double> p in pProd){
                switch(p.Key[0]){
                    case 'A':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 'P':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 'Z':
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("{0} - {1}", p.Key, p.Value);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
