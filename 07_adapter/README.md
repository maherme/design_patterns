#  Adapter
 - It allows object with incompatible interfaces to communicate.
 - It converts the interface of one object so that another object can understand it.

## UML Diagram
### General
- **Client** is the user of the pattern. It can work with ITarget interface but not with Adaptee.
- **ITarget** is the interface used by the client.
- **Adaptee** is the class to be adapted, the client can not work directly with this class.
- **Adapter** adapts the Adaptee interface to ITarget interface.
```mermaid
  classDiagram
    class Client
    class ITarget{
      <<interface>>
      +request()
    }
    class Adapter{
      +request()
    }
    class Adaptee{
      +specificRequest()
    }
    Client o--|> ITarget
    Adapter ..|> ITarget
    Adapter o--|> Adaptee
```
### For this example
```mermaid
  classDiagram
    class Program
    class ITarget{
      <<interface>>
      +Addition(int pA, int pB) int
    }
    class CAdapter{
      +Addition(int pA, int pB) int
    }
    class CCalculator{
      +Addition(int pA, int pB) int
    }
    class CCalculatorArray{
      +AdditionArray(int[] pOperands) double
    }
    Program o--|> CCalculator
    Program o--|> ITarget
    CAdapter ..|> ITarget
    CAdapter o--|> CCalculatorArray
```
