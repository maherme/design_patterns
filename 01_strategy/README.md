# Strategy
 - It is built with different encapsulated algorithms.
 - The client selects the algorithm to use.
 - It can be implemented using inheritance or implementing interfaces.

## UML Diagram
### General
```mermaid
  classDiagram
      class Client
      class IStrategy{
          <<interface>>
          +Algorithm()
      }
      class Strategy1{
          +Algorithm()
      }
      class Strategy2{
          +Algorithm()
      }
      Client o-- IStrategy
      Strategy1 ..|> IStrategy
      Strategy2 ..|> IStrategy
```
### For this example
```mermaid
  classDiagram
      class Program
      class IOperation{
          <<interface>>
          +operation()
      }
      class CAdd{
          +operation()
      }
      class CSub{
          +operation()
      }
      class CMult{
          +operation()
      }
      class CDiv{
          +operation()
      }
      Program o-- IOperation
      CAdd ..|> IOperation
      CSub ..|> IOperation
      CMult ..|> IOperation
      CDiv ..|> IOperation
```
