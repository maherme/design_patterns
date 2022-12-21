# Builder
 - It decouples the specificaton of an object of its constructor.
 - The same constructor process can creates different representations.
 - It is based on directors and constructors.
 - It is used for creating complex structures.
 - It is used when the algorithm used for creating the parts is independent of the parts itself.
 - It is useful when an accurate control of the construction process is required.

## UML Diagram
### General
- **Client** is the user of the pattern.
- **IConstructor** is the interface which defines what can be constructed.
- **Director** implements a sequence of operations to create a product.
- **Constructor** is invoked by the director to create the parts of the product.
- **Product** is the object under construction.

```mermaid
  classDiagram
    class Client
    class Director
    class IConstructor{
      <<interface>>
    }
    class Constructor
    class Product
    Client o-- Director
    Client o-- IConstructor
    Director o-- IConstructor
    Constructor ..|> IConstructor
    Constructor o-- Product
```
### For this example
```mermaid
  classDiagram
    class Program
    class CDirector{
      +Build(IBuilder pBuilder) void
    }
    class CProducts{
      -IMotor motor
      -IBody body
      -IWheels wheels
      +InstallMotor(IMotor pMotor) void
      +InstallBody(IBody pBody) void
      +InstallWheels(IWheels pWheels) void
      +ShowAuto() void
    }
    class IBuilder{
      <<interface>>
      +BuildMotor() void
      +BuildBody() void
      +BuildWheels() void
    }
    class CNormalBuilder{
      +BuildMotor() void
      +BuildBody() void
      +BuildWheels() void
      +GetProduct() CProduct
    }
    class CSportBuilder{
      +BuildMotor() void
      +BuildBody() void
      +BuildWheels() void
      +GetProduct() CProduct
    }
    class IMotor{
      <<interface>>
      +Specs() string
    }
    class CBasicMotor{
      +Specs() string
    }
    class CPowerMotor{
      +Specs() string
    }
    class IBody{
      <<interface>>
      +Features() string
    }
    class CBasicBody{
      +Features() string
    }
    class CSpecialBody{
      +Features() string
    }
    class IWheels{
      <<interface>>
      +Info() string
    }
    class CWheels{
      +Info() string
    }
    class CSuperWheels{
      +Info() string
    }
    Program o-- CDirector
    Program o-- IBuilder
    CDirector o-- IBuilder
    CNormalBuilder ..|> IBuilder
    CNormalBuilder o-- CProducts
    CSportBuilder ..|> IBuilder
    CSportBuilder o-- CProducts
    CProducts --|> IMotor
    CProducts --|> IBody
    CProducts --|> IWheels
    CBasicMotor ..|> IMotor
    CPowerMotor ..|> IMotor
    CBasicBody ..|> IBody
    CSpecialBody ..|> IBody
    CWheels ..|> IWheels
    CSuperWheels ..|> IWheels
```
