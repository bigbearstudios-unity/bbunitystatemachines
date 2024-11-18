using System;
using System.Collections.Generic;

namespace BBUnity.StateMachines.Specialised {

    /// <summary>
    /// TODO
    /// Not finished
    /// </summary>
    // public class TransitionalStateMachine {

    //     /// <summary>
    //     /// Dictionary of all of the transitions within the state machine. These are key'ed by Type of the
    //     /// from transitions
    //     /// </summary>
    //     /// <returns></returns>
    //     private Dictionary<Type, List<StateTransition>> _transitions = new Dictionary<Type, List<StateTransition>>();

    //     /// <summary>
    //     /// The avalible transitions for the current state, this is purely a reference to a list stored within
    //     /// _transitions.
    //     /// </summary>
    //     private List<StateTransition> _availableTransitions = null;

    //     /// <summary>
    //     /// List of the 'any' transitions. Defaults to an empty list.
    //     /// </summary>
    //     /// <returns></returns>
    //     private List<StateTransition> _anyTransitions = new List<StateTransition>(0);

    //     /// <summary>
    //     /// An Empty list of Transitions. This is the default for the _availableTransitions
    //     /// </summary>
    //     private static List<StateTransition> EmptyTransitions = new List<StateTransition>(0);

    //     public TransitionalStateMachine() : base() {
    //         SetAvailableTransitionsToEmpty();
    //     }

    //     /// <summary>
    //     /// Updates the state machine. This will:
    //     /// - Find the next transition
    //     /// - Calls OnTick on the current transition
    //     /// </summary>
    //     // public override void Update() {
    //     //     StateTransition transition = FindNextTransition();
    //     //     if(transition != null) {
    //     //         SetState(transition.To);
    //     //     }

    //     //     base.Update();
    //     // }

    //     // public void Add(State from, State to, Func<bool> predicate) {
    //     //     GetTransitions(from.GetType()).Add(new StateTransition(to, predicate));
    //     // }

    //     public void Add(State from, StateTransition[] newTransitions) {
    //         List<StateTransition> transitions = GetTransitions(from.GetType());

    //         foreach(StateTransition transition in newTransitions) {
    //             transitions.Add(transition);
    //         }
    //     }

    //     private void SetAvailableTransitionsToEmpty() {
    //         _availableTransitions = EmptyTransitions;
    //     }

    //     private List<StateTransition> GetTransitions(Type forType) {
    //         if(_transitions.TryGetValue(forType, out List<StateTransition> transitions) == false) {
    //             transitions = new List<StateTransition>();
    //             _transitions[forType] = transitions;
    //         }

    //         return transitions;
    //     }

    //     /// <summary>
    //     /// Adds an any transition. When the predicate returns true the transition
    //     /// will be called no matter the current state.
    //     /// </summary>
    //     /// <param name="to"></param>
    //     /// <param name="predicate"></param>
    //     // public void Add(State to, Func<bool> predicate) {
    //     //     _anyTransitions.Add(
    //     //         new StateTransition(to, predicate)
    //     //     );
    //     // }

    //     /// <summary>
    //     /// Replaces the current state, calls the callbacks on the old / new states.
    //     /// This version also sets the _availableTransitions using the new state.
    //     /// </summary>
    //     /// <param name="oldState"></param>
    //     /// <param name="newState"></param>
    //     /// <returns></returns>
    //     // protected override bool ReplaceState(State oldState, State newState) {
    //     //     oldState?.OnExit();
    //     //     _currentState = newState;

    //     //     _transitions.TryGetValue(newState.GetType(), out _availableTransitions);
    //     //     if(_availableTransitions == null) { SetAvailableTransitionsToEmpty(); }

    //     //     newState?.OnEnter();

    //     //     return true;
    //     // }

    //     /// <summary>
    //     /// Finds the next transition, this will iterate through all _anyTransitions
    //     /// then through all _avalible
    //     /// </summary>
    //     /// <returns></returns>
    //     private StateTransition FindNextTransition() {
    //         foreach(StateTransition transition in _anyTransitions) {
    //             if(transition.CanTransition) {
    //                 return transition;
    //             }
    //         }

    //         foreach(StateTransition transition in _availableTransitions) {
    //             if(transition.CanTransition) {
    //                 return transition;
    //             }
    //         }

    //         return null;
    //     }
    // }
}