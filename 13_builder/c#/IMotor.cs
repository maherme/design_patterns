namespace Builder
{
    interface IMotor
    {
        string Specs();
    }

    class CBasicMotor:IMotor
    {
        public string Specs(){
            return "4 cylinders motor";
        }
    }

    class CPowerMotor:IMotor
    {
        public string Specs(){
            return "8 cylinders motor";
        }
    }
}
