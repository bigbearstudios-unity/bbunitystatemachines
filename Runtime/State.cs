using System;

namespace BBUnity.StateMachines {

    internal class StateAlreadyAssignedException : Exception {
        public StateAlreadyAssignedException() { }
        public StateAlreadyAssignedException(string message) : base(message) {}
        public StateAlreadyAssignedException(string message, Exception inner) : base(message, inner) {}
    }

    /// <summary>
    /// A single State 
    /// 
    /// Follows the simple flow of:
    /// - Constuctor (Called when the state is created)
    /// - OnEnter (Called upon entering the state)
    /// - OnExit (Called upon leaving the state)
    /// - OnTick (Called upon a tick / update)
    /// </summary>
    public abstract class State : IState {

        protected StateMachine _subStateMachine;
        protected StateMachine SubStateMachine {
            get { return _subStateMachine; }
        }

        protected StateMachine _stateMachine;
        protected StateMachine StateMachine { get { return _stateMachine; } }
        internal void SetStateMachine(StateMachine stateMachine) {
            if(_stateMachine != null) throw new StateAlreadyAssignedException();

            _stateMachine = stateMachine; 
        }

        /// <summary>
        /// Called upon the owning StateMachine's update
        /// being called
        /// </summary>
        public virtual void OnUpdate() {}

        /// <summary>
        /// Called upon entering the state
        /// </summary>
        public virtual void OnEnter() {}

        /// <summary>
        /// Called upon exiting the state
        /// </summary>
        public virtual void OnExit() {}
    }
}