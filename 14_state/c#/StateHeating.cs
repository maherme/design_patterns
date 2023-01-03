using System;

namespace State
{
    class StateHeating:IState
    {
        CBoiler myBoiler;

        public StateHeating(CBoiler pBoiler){
            myBoiler = pBoiler;
        }

        public void Working(){
            if(myBoiler.Fuel > 0){
                Console.WriteLine("Heating");
                myBoiler.Fuel -= 3;
                myBoiler.Temperature += 10;
            }
            // Check a possible state change
            if(myBoiler.Temperature > 100){
                myBoiler.ChangeState(myBoiler.Alarm);
            }
            else if(myBoiler.Temperature > 80){
                myBoiler.ChangeState(myBoiler.Wait);
            }
            else{
                // Do nothing
            }
            if(myBoiler.Fuel <= 0){
                myBoiler.ChangeState(myBoiler.Wait);
            }
        }

        public void StopLighting(){
            Console.WriteLine("Stop Lighting");
            myBoiler.ChangeState(myBoiler.Wait);
        }

        public void FillFuel(){
            Console.WriteLine("It is not possible fill fuel when the boiler is working");
        }

        public void ForceLighting(){
            Console.WriteLine("Force Lighting");
        }

        public override string ToString(){
            return string.Format("Heating -> temp {0}, fuel {1}", myBoiler.Temperature, myBoiler.Fuel);
        }
    }
}
