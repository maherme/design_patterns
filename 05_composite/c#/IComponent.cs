namespace Composite
{
    interface IComponent<T>
    {
        T Name{get; set;}
        void Addition(IComponent<T> pElement);
        IComponent<T> Erase(T pElement);
        IComponent<T> Search(T pElement);
        string Show(int pDeep);
    }
}
