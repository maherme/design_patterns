using System;
using System.Collections.Generic;

namespace Bridge
{
    class CImplementation1:IBridge
    {
        public void ShowTotalImp(Dictionary<string, double> pProd)
        {
            double total = 0;
            int amount = 0;

            foreach(KeyValuePair<string, double> p in pProd){
                total += p.Value;
                amount++;
            }
            Console.WriteLine("Total of {0} products is {1}$", amount, total);
        }

        public void ListTotalImp(Dictionary<string, double> pProd)
        {
            foreach(KeyValuePair<string, double> p in pProd){
                Console.WriteLine(p.Key);
            }
        }
    }
}
