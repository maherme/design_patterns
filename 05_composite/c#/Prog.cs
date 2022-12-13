using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent<string> tree = new CComposite<string>("root");
            IComponent<string> node = tree;
            string option = "";
            string data = "";

            while(option != "6"){
                Console.WriteLine("Node is {0}", node.Name);
                Console.WriteLine("1-Add Composite 2-Add Component 3-Erase 4-Search 5-Show 6-Exit");
                option = Console.ReadLine();
                Console.WriteLine("-------------------------------------------------------");

                switch(option){
                    case "1":
                        Console.WriteLine("Type the name of the composite: ");
                        data = Console.ReadLine();
                        IComponent<string> composite = new CComposite<string>(data);
                        node.Addition(composite);
                        node = composite;
                        break;
                    case "2":
                        Console.WriteLine("Type the name of the component: ");
                        data = Console.ReadLine();
                        IComponent<string> component = new CComponent<string>(data);
                        node.Addition(component);
                        break;
                    case "3":
                        Console.WriteLine("Type the element to be erased: ");
                        data = Console.ReadLine();
                        node = node.Erase(data);
                        break;
                    case "4":
                        Console.WriteLine("Type the element to find: ");
                        data = Console.ReadLine();
                        node = tree.Search(data);
                        break;
                    case "5":
                        Console.WriteLine(tree.Show(0));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
