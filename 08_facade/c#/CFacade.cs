namespace Subsystems
{
    class CFacade
    {
        // Subsystems used
        private CPurchaseSystem purchase = new CPurchaseSystem();
        private CStorageSystem storage = new CStorageSystem();
        private CShipmentSystem shipment = new CShipmentSystem();

        // This method is used to perform a more complex method, in this case the Purchase, GetStorage and
        // SendOrder in only one simpler as Buy.
        public void Buy(){
            if(purchase.Purchase()){
                if(storage.GetStorage()){
                    shipment.SendOrder();
                }
            }
        }
    }
}
