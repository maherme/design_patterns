using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            CBoiler myBoiler = new CBoiler();
            string option;

            do{
                Console.WriteLine("1- Stop Lighting, 2- Fill Fuel, 3- Force Lighting, 4- Exit");
                option = Console.ReadLine();
                myBoiler.Working();

                switch(option){
                    case "1":
                        myBoiler.StopLighting();
                        break;
                    case "2":
                        myBoiler.FillFuel();
                        break;
                    case "3":
                        myBoiler.ForceLighting();
                        break;
                    default:
                        //do nothing
                        break;
                }
                Console.WriteLine(myBoiler);
            }while(option != "4");
        }
    }
}
