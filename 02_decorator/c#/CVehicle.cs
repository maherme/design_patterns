using System;

namespace Decorator{

    class CVehicle:IComponent{
        private string model;
        private string features;
        public double price;

        public CVehicle(string pModel, string pFeatures, double pPrice){
            model = pModel;
            features = pFeatures;
            price = pPrice;
        }

        public void Engine(bool pState){
            if(pState){
                Console.WriteLine("Engine is started");
            }
            else{
                Console.WriteLine("Engine is stoped");
            }
        }

        public override string ToString(){
            return string.Format("Model {0}, {1}", model, features);
        }

        // Methods from interface IComponent
        public double Price(){
            return price;
        }

        public string Working(){
            return "Vehicle is running";
        }
    }
}
