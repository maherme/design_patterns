using System;
using System.Collections.Generic;

namespace Bridge
{
    class CImplementation3:IBridge
    {
        public void ShowTotal(Dictionary<string, double> pProd)
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
                amount ++;
            }
            Console.WriteLine("Total of A is {0}$, {1}% of the total", totalA, totalA/total*100);
            Console.WriteLine("Total of P is {0}$, {1}% of the total", totalP, totalP/total*100);
            Console.WriteLine("Total of Z is {0}$, {1}% of the total", totalZ, totalZ/total*100);
            Console.WriteLine("Total of {0} products is {1}$", amount, total);
        }

        public void ListTotal(Dictionary<string, double> pProd)
        {
            foreach(KeyValuePair<string, double> p in pProd){
                Console.ForegroundColor = ConsoleColor.Yellow;
                if(p.Key[0] == 'A'){
                    Console.WriteLine("{0} - {1}", p.Key, p.Value);
                }
            }
            foreach(KeyValuePair<string, double> p in pProd){
                Console.ForegroundColor = ConsoleColor.Blue;
                if(p.Key[0] == 'P'){
                    Console.WriteLine("{0} - {1}", p.Key, p.Value);
                }
            }
            foreach(KeyValuePair<string, double> p in pProd){
                Console.ForegroundColor = ConsoleColor.Red;
                if(p.Key[0] == 'Z'){
                    Console.WriteLine("{0} - {1}", p.Key, p.Value);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
