using System;
using Subsystems;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CFacade facade = new CFacade();
            for(int n = 0; n < 5; n++){
                facade.Buy();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
