namespace Factory
{
    class CCreator
    {
        public static IVehicle FabricMethod(int pMoney){
            IVehicle temp = null;
            // Select the type of instance depending on pMoney
            if(pMoney > 10000000){
                temp = new CPlane();
            }
            else if(pMoney > 200000){
                temp = new CAuto();
            }
            else{
                temp = new CBike();
            }
            return temp;
        }
    }
}
