namespace Builder
{
    class CNormalBuilder:IBuilder
    {
        private CProduct auto = new CProduct();

        public void BuildMotor(){
            auto.InstallMotor(new CBasicMotor());
        }

        public void BuildBody(){
            auto.InstallBody(new CBasicBody());
        }

        public void BuildWheels(){
            auto.InstallWheels(new CWheels());
        }

        public CProduct GetProduct(){
            return auto;
        }
    }
}
