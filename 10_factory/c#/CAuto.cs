using System;

namespace Factory
{
    class CAuto:IVehicle
    {
        public void Start(){
            Console.WriteLine("Insert and turn the key");
        }

        public void Accelerate(){
            Console.WriteLine("Press accelerator pedal");
        }

        public void Brake(){
            Console.WriteLine("Press brake pedal");
        }

        public void Steer(){
            Console.WriteLine("Use the steering wheel");
        }
    }
}
