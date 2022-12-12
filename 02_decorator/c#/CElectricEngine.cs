using System;

namespace Decorator{

    class CElectricEngine:IComponent{
        // Reference variable for communicating with the object to decorate
        private IComponent obj_to_decorate;

        // The link to the object to decorate is done in the constructor
        public CElectricEngine(IComponent pComponent){
            obj_to_decorate = pComponent;
        }

        public override string ToString(){
            return obj_to_decorate.ToString() + ", Electric Engine";
        }

        // Methods from interface IComponent, they will be decorated
        public double Price(){
            // Calculate the price adding the autopilot price
            return obj_to_decorate.Price() + 7500;
        }

        public string Working(){
            // Add autopilot feature to working information
            return obj_to_decorate.Working() + ", Electric Engine working";
        }
    }
}
