using System;

namespace Decorator{

    class CTurbo:IComponent{
        // Reference variable for communicating with the object to decorate
        private IComponent obj_to_decorate;

        // The link to the object to decorate is done in the constructor
        public CTurbo(IComponent pComponent){
            obj_to_decorate = pComponent;
        }

        public override string ToString(){
            return obj_to_decorate.ToString() + ", Turbo system";
        }

        // Methods from interface IComponent, they will be decorated
        public double Price(){
            // Calculate the price adding the turbo price
            return  obj_to_decorate.Price() + 2500;
        }

        public string Working(){
            // Add turbo feature to working information
            return obj_to_decorate.Working() + ", Turbo is ready";
        }

        // This is a method of CTurbo, is not a decoration
        public void UseTurbo(){
            Console.WriteLine("Turbo in use");
        }
    }
}
