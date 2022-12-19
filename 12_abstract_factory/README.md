# Abstract Factory
 - It lets you produce families of related objects without specifying their concrete classes.
 - It provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.

## UML Diagram
### General
- **Client** is the user of the pattern, it is only access to the created object through the abstract interfaces.
- **IAbstractFactory** is the interface for the Factory.
- **Factory** is the class which implements the interface of the abstract factory (IAbstractFactory).
- **IProduct** is the interface for the product created by the Factory.
- **Product** is the class which implement the interface IProduct, and the final object created by the Factory which is demanded by the Client.

```mermaid
  classDiagram
    class Client
    class IAbstractFactory{
      <<interface>>
    }
    class FactoryA
    class FactoryB
    class IProduct1{
      <<interface>>
    }
    class Product1A
    class Product1B
    class IProduct2{
      <<interface>>
    }
    class Product2A
    class Product2B
    Client o-- IAbstractFactory
    Client o-- IProduct1
    Client o-- IProduct2
    FactoryA ..|> IAbstractFactory
    FactoryB ..|> IAbstractFactory
    FactoryA ..> Product1A
    FactoryA ..> Product2A
    FactoryB ..> Product1B
    FactoryB ..> Product2B
    Product1A ..|> IProduct1
    Product1B ..|> IProduct1
    Product2A ..|> IProduct2
    Product2B ..|> IProduct2
```
### For this example
```mermaid
  classDiagram
    class Program
    class IFactory
    class CNaturalFactory
    class CChemicalFactory
    class IProductMilk
    class CCowMilk
    class CCoconutMilk
    class CAlmondMilk
    class IProductFlavoring
    class CNaturalVanilla
    class CChocolateFlavor
```
