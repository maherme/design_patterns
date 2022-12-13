using System.Collections.Generic;

namespace Bridge
{
    interface IBridge
    {
        void ShowTotalImp(Dictionary<string, double> pProduct);
        void ListTotalImp(Dictionary<string, double> pProduct);
    }
}
