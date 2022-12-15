# Flyweight
 - It refers to an object that minimizes memory usage by sharing some of its data with other similar objects.
 - It allows you to save resources (RAM).
 - It should be used when there are a high number of similar objects.
 - It increases the CPU load.
 - The object has two states:
   - Intrinsic state: it is the invariable state, it can be shared.
   - Extrinsic state: it is the variant state, it can not be shared.

## UML Diagram
### General
- **CFlyweight** is which implements the IFlyweight and stores intrinsic state.
- **IFlyweight** is which takes in extrinsic state and performs an operation.
- **FlyweightFactory** is which creates and shares Flyweight objects.
- **Client** is the user of the pattern.
```mermaid
  classDiagram
   class Client
   class FlyweightFactory{
     -flyweights_collection
     +getFlyweight()
   }
   class IFlyweight{
     <<interface>>
     +operation(extrinsicData)
   }
   class CFlyweight{
     -intrinsicState
     +operation(extrinsicData)
   }
   Client --|> FlyweightFactory
   Client --|> CFlyweight
   CFlyweight ..|> IFlyweight
   FlyweightFactory o-- IFlyweight
```
### For this example
```mermaid
  classDiagram
    class Program
    class IFlyweight{
      <<interface>>
      +void AddName(string pName);
      +void CalculatePrice();
      +void Show();
      +string GetName();
    }
    class CFlyweightFactory{
      -List flyweights
      +int Addition(string pName)
    }
    class CRecipe{
      -string name
      -double price
      -double sale
      +void AddName(string pName);
      +void CalculatePrice();
      +void Show();
      +string GetName();
    }
    Program --|> CFlyweightFactory
    Program --|> CRecipe
    CRecipe ..|> IFlyweight
    CFlyweightFactory o-- IFlyweight
```
