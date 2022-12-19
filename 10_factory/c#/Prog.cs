using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            int money;
            IVehicle vehicle;

            Console.WriteLine("How much money do you have?");
            data = Console.ReadLine();
            money = Convert.ToInt32(data);

            // Get the vehicle from the factory
            vehicle = CCreator.FabricMethod(money);

            vehicle.Start();
            vehicle.Accelerate();
            vehicle.Brake();
            vehicle.Steer();
        }
    }
}
