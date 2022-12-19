# Factory
- Decouple the creation of an object to the client.
- The creation of an object is done using a factory method.
- The decision of creating an object is not taken by the client.

## UML Diagram
### General
- **Client** is the user of the pattern, but it does not decide which product is created.
- **Creator** is the class which implements the method for creating the products.
- **IProduct** is the interface of the products.
- **Product** is the class used by the creator (produced by the factory).
```mermaid
  classDiagram
    class Client
    class Creator{
      +FactoryMethod()
    }
    class IProduct{
      <<interface>>
    }
    class Product
    Client o--|> Creator
    Client o--IProduct
    Creator --|> Product
    Product "1..n" ..|> IProduct
```
### For this example
```mermaid
  classDiagram
    class Program
    class CCreator{
      +IVehicle FabricMethod(int pMoney)
    }
    class IVehicle{
      <<interface>>
      +void Start()
      +void Accelerate()
      +void Brake()
      +void Steer()
    }
    class CAuto{
      +void Start()
      +void Accelerate()
      +void Brake()
      +void Steer()
    }
    class CBike{
      +void Start()
      +void Accelerate()
      +void Brake()
      +void Steer()
    }
    class CPlane{
      +void Start()
      +void Accelerate()
      +void Brake()
      +void Steer()
    }
    Program o-- IVehicle
    Program o--|> CCreator
    CCreator --|> CAuto
    CCreator --|> CBike
    CCreator --|> CPlane
    CAuto ..|> IVehicle
    CBike ..|> IVehicle
    CPlane ..|> IVehicle
```
