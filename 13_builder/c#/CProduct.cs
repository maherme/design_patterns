using System;

namespace Builder
{
    class CProduct
    {
        private IMotor motor;
        private IBody body;
        private IWheels wheels;

        public void InstallMotor(IMotor pMotor){
            motor = pMotor;
            Console.WriteLine("Motor is installed: {0}", motor.Specs());
        }

        public void InstallBody(IBody pBody){
            body = pBody;
            Console.WriteLine("Body is installed: {0}", body.Features());
        }

        public void InstallWheels(IWheels pWheels){
            wheels = pWheels;
            Console.WriteLine("Wheels are installed: {0}", wheels.Info());
        }

        public void ShowAuto(){
            Console.WriteLine("Your auto has installed {0}, {1}, {2}",
                              motor.Specs(),
                              body.Features(),
                              wheels.Info());
        }
    }
}
