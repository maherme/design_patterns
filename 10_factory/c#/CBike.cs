using System;

namespace Factory
{
    class CBike:IVehicle
    {
        public void Start(){
            Console.WriteLine("Bike does not nedd starting");
        }

        public void Accelerate(){
            Console.WriteLine("Pedal harder for accelerating");
        }

        public void Brake(){
            Console.WriteLine("Press rear brake first");
        }

        public void Steer(){
            Console.WriteLine("Use the handlebar");
        }
    }
}
