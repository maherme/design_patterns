namespace Prototype
{
    class CAuto:IPrototype
    {
        private string model;
        private int price;
        public string Model{get => model; set => model = value;}

        public CAuto(string pModel, int pPrice){
            model = pModel;
            price = pPrice;
        }

        public override string ToString(){
            return string.Format("Auto: {0}, {1}", model, price);
        }

        public object Clone(){
            CAuto clon = new CAuto(model, price);
            return clon;
        }
    }
}
