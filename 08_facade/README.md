# Facade
 - It provides a simplified interface to a complex subsystem.
 - It can be used to provide a simpler interface, to order subsystems in layers or to decouple subsystems from the clients.

## UML Diagram
### General
- **Client** is the user of the pattern. It uses the simplified interface instead the interfaces provided by the subsystems.
- **Facade** is the class which simplifies the Subsystem usage to the Client.
- **Subsystem** is the end point, it performs an operation needed by the client.
```mermaid
  classDiagram
    class Client
    class Facade{
      +facadeOperation()
    }
    class Subsystem{
      +subsystemOperation()
    }
    Client --|> Facade
    Facade o--|> "1..n" Subsystem
```
### For this example
```mermaid
  classDiagram
    class Program
    class CFacade{
      +void Buy()
    }
    class CPurchaseSystem{
      +bool Purchase()
    }
    class CStorageSystem{
      +bool GetStorage()
    }
    class CShipmentSystem{
      +void SendOrder()
    }
    Program --|> CFacade
    CFacade o--|> CPurchaseSystem
    CFacade o--|> CStorageSystem
    CFacade o--|> CShipmentSystem
```
