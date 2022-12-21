using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CDirector myDirector = new CDirector();

            CNormalBuilder normal = new CNormalBuilder();
            myDirector.Build(normal);

            CProduct auto1 = normal.GetProduct();
            auto1.ShowAuto();

            Console.WriteLine("-----------------------------------");

            CSportBuilder sport = new CSportBuilder();
            myDirector.Build(sport);

            CProduct auto2 = sport.GetProduct();
            auto2.ShowAuto();
        }
    }
}
