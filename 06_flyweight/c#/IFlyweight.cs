namespace Flyweight
{
    interface IFlyweight
    {
        void AddName(string pName);
        void CalculatePrice();
        void Show();
        string GetName();
    }
}
