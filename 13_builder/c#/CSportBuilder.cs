namespace Builder
{
    class CSportBuilder:IBuilder
    {
        private CProduct auto = new CProduct();

        public void BuildMotor(){
            auto.InstallMotor(new CPowerMotor());
        }

        public void BuildBody(){
            auto.InstallBody(new CSpecialBody());
        }

        public void BuildWheels(){
            auto.InstallWheels(new CSuperWheels());
        }

        public CProduct GetProduct(){
            return auto;
        }
    }
}
