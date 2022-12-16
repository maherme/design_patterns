using System;

namespace Subsystems
{
    class CPurchaseSystem
    {
        public bool Purchase(){
            string data = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Insert card number");
            data = Console.ReadLine();

            if(data == "12345"){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Payment Accepted");
                return true;
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Payment Dennied");
                return false;
            }
        }
    }

    class CStorageSystem
    {
        private int quantity;

        public CStorageSystem(){
            quantity = 3;
        }

        public bool GetStorage(){
            if(quantity > 0){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Product ready to send");
                quantity--;
                return true;
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Product is not available, wait for stock");
                return false;
            }
        }
    }

    class CShipmentSystem
    {
        public void SendOrder(){
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Order shipped");
        }
    }
}
