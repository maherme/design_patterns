# Decorator
 - Add a new behaviour or state to an object in a dynamic way.
 - The object does not know it is being decorated.
 - Each decorator is independent of the rest of decorators.
 - The decorator has an instance of the original class and it descens of this class also.
 - It does not depend on the inheritance for adding new behaviours.

## UML Diagram
### General
```mermaid
  classDiagram
    class Client
    class Component{
      +decorated_method()
    }
    class IComponent{
      <<interface>>
      +decorated_method()
    }
    class ComponentDecorator{
      -component IComponent
      +decorated_method()
    }
    class Decorator1{
      +decorated_method()
    }
    class Decorator2{
      +decorated_method()
    }
    ComponentDecorator o-- IComponent
    ComponentDecorator ..|> IComponent
    Component ..|> IComponent
    Decorator1 --|> ComponentDecorator
    Decorator2 --|> ComponentDecorator
    Client o-- Component
```
### For this example
```mermaid
  classDiagram
    class Program
    class CVehicle{
      +Price()
      +Working()
      +Engine()
    }
    class IComponent{
      <<interface>>
      +Price()
      +Working()
    }
    class CTurbo{
      -obj_to_decorate IComponent
      +Price()
      +Working()
      +UseTurbo()
    }
    class CAutopilot{
      -obj_to_decorate IComponent
      +Price()
      +Working()
    }
    class CElectricEngine{
      -obj_to_decorate IComponent
      +Price()
      +Working()
    }
    Program o-- CVehicle
    Program o-- CTurbo
    Program o-- CAutopilot
    Program o-- CElectricEngine
    CVehicle ..|> IComponent
    CTurbo ..|> IComponent
    CAutopilot ..|> IComponent
    CElectricEngine ..|> IComponent
```
