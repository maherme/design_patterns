using System.Collections.Generic;

namespace Bridge
{
    interface IBridge
    {
        void ShowTotal(Dictionary<string, double> pProduct);
        void ListTotal(Dictionary<string, double> pProduct);
    }
}
