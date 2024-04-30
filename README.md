# BBUnity State Machines

## Creating a State

A State is the base class from which all state should derive:

```csharp

enum States {
    Running,
    Attacking
}

class MyState : State {
    public void OnTick() {
        Object.DoSomethingOnTick();
    }

    public void OnEnter() {
        Object.DoSomethingOnEnter();
    }

    public void OnExit() {
        Object.DoSomethingOnExit();
    }
}

stateMachine = new StateMachine() {
    { States.Running, new State(), true }, // This state is marked as the 'default' state
    { States.Attacking, new State() } // The object can be accessed within the state
}

```

Once a state is running you can then 

## TODO List

- Tests required for TransitionalStateMachine