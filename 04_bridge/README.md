# Bridge
 - Disconnect implementation from abstraction.
 - The client chooses which version of implementation wants to use.
 - An interface is used to provide access to the implementations.

## UML Diagram
### General
```mermaid
  classDiagram
    class Client
    class Abstraction{
      +Operation()
    }
    class Implementor{
      <<interface>>
      +OperationImp()
    }
    class Implementation1{
      +OperationImp()
    }
    class ImplementationN{
      +OperationImp()
    }
    Client --|> Abstraction
    Abstraction --|> Implementor
    Implementation1 ..|> Implementor
    ImplementationN ..|> Implementor
```
### For this example
```mermaid
  classDiagram
    class Program
    class CAbstraction{
      +ShowTotal()
      +ListTotal()
    }
    class IBridge{
      <<interface>>
      +ShowTotalImp()
      +ListTotalImp()
    }
    class Implementation1{
      +ShowTotalImp()
      +ListTotalImp()
    }
    class Implementation2{
      +ShowTotalImp()
      +ListTotalImp()
    }
    class Implementation3{
      +ShowTotalImp()
      +ListTotalImp()
    }
    Program --|> CAbstraction
    CAbstraction --|> IBridge
    Implementation1 ..|> IBridge
    Implementation2 ..|> IBridge
    Implementation3 ..|> IBridge
```
