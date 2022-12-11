# Strategy
 - It is built with different encapsulated algorithms.
 - The client selects the algorithm to use.
 - It can be implemented using inheritance or implementing interfaces.

## UML Diagram 
```mermaid
  classDiagram
      Client o-- IStrategy
      Strategy1 ..|> IStrategy
      Strategy2 ..|> IStrategy
      IStrategy : Algorithm()
      Strategy1 : Algorithm()
      Strategy2 : Algorithm()
```
