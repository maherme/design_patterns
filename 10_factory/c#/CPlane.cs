using System;

namespace Factory
{
    class CPlane:IVehicle
    {
        public void Start(){
            Console.WriteLine("Follow the procedure");
        }

        public void Accelerate(){
            Console.WriteLine("Push the accelerator");
        }

        public void Brake(){
            Console.WriteLine("Pull the accelerator");
        }

        public void Steer(){
            Console.WriteLine("Move the rudder of the tail");
        }
    }
}
