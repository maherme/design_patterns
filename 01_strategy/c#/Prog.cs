using System;

namespace Strategy{

    class Program{
        static void Main(string[] args){
            string read_operand = "";
            double first_operand = 0;
            double second_operand = 0;
            double result = 0;
            string option = "";

            // Default instantiation for compilation
            IOperation myOperation = new CAdd();

            while(option != "5"){
                Console.WriteLine("1 Addition, 2 Subtraction, 3 Multiplication, 4 Division, 5 Exit");
                option = Console.ReadLine();
                if(option == "5"){
                    break;
                }
                Console.WriteLine("Type value for first operand");
                read_operand = Console.ReadLine();
                first_operand = Convert.ToDouble(read_operand);

                Console.WriteLine("Type value for second operand");
                read_operand = Console.ReadLine();
                second_operand = Convert.ToDouble(read_operand);

                //Algorithm selection. This is done in execution time.
                if(option == "1"){
                    myOperation = new CAdd();
                }
                if(option == "2"){
                    myOperation = new CSub();
                }
                if(option == "3"){
                    myOperation = new CMult();
                }
                if(option == "4"){
                    myOperation = new CDiv();
                }

                result = myOperation.operation(first_operand, second_operand);

                Console.WriteLine("Result is {0}", result);
            }
        }
    }
}
