# Prototype
- It lets you copy existing objects without making your code dependent on their classes.
- It is used to avoid the inherent cost of creating a new object in the standard way when it is prohibitively expensive for a given application.
- This pattern delegates the cloning process to the actual objects that are being cloned.
- An interface contains just a single clone method

## UML Diagram
### General
- **Client** can produce a copy of any object which implements the IPrototype interface.
- **IPrototype** is the interface which declares the cloning method.
- **Prototype** implements the cloning method. It copies the original object’s data to the clone.
```mermaid
  classDiagram
    class Client
    class IPrototype{
      <<interface>>
      +clone()
    }
    class Prototype{
      +clone()
    }
    Client --|> IPrototype
    Prototype ..|> IPrototype
```
### For this example
```mermaid
  classDiagram
    class Program
    class IPrototype{
      <<interface>>
      +Clone() object
    }
    class CAdminPrototypes{
      -Dictionary prototypes
      +AddPrototype(string pKey, IPrototype pPrototype) void
      +CreatePrototype(string pKey) object
    }
    class CValues{
      -double summation
      -int m
      +Clone() object
    }
    class CAuto{
      -string model
      -int price
      +Clone() object
    }
    class CPerson{
      -string name
      -int age
      +Clone() object
    }
    Program o--|> CAdminPrototypes
    CAdminPrototypes o--|> IPrototype
    CValues ..|> IPrototype
    CAuto ..|> IPrototype
    CPerson ..|> IPrototype
```
