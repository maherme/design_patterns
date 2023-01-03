# State
 - It is a finite state machine implementation.
 - It is useful when you need to change the behaviour in execution time, according with the context.

## UML Diagram
### General
- **Context** it has the instance of the State and the interface.
- **IState** defines the interface for a particular state in the context.
- **State** is a class which implements a particular state.

```mermaid
  classDiagram
    class Context
    class IState{
      <<interface>>
    }
    class State1
    class State2
    Context o-- IState
    State1 ..|> IState
    State2 ..|> IState
```
### For this example
```mermaid
  classDiagram
    class Program{
      +CBoiler myBoiler
    }
    class IState{
      <<interface>>
      +Working() void
      +StopLighting() void
      +FillFuel() void
      +ForceLighting() void
    }
    class StateHeating{
      +Working() void
      +StopLighting() void
      +FillFuel() void
      +ForceLighting() void
    }
    class StateWaiting{
      +Working() void
      +StopLighting() void
      +FillFuel() void
      +ForceLighting() void
    }
    class StateAlarm{
      +Working() void
      +StopLighting() void
      +FillFuel() void
      +ForceLighting() void
    }
    class CBoiler{
      -IState current_state
      -int temperature
      -int fuel
      +ChangeState(IState pState) void
    }
    Program --|> CBoiler
    CBoiler o-- IState
    StateHeating ..|> IState
    StateWaiting ..|> IState
    StateAlarm ..|> IState
```
