using System;

namespace BBUnity.StateMachines.Specialised {

    /// <summary>
    /// A single transition to another state within the
    /// state machine along with a condition
    /// </summary>
    public class StateTransition {
        /// <summary>
        /// The state to move to
        /// </summary>
        private State _to;
        public State To { get { return _to; } }

        /// <summary>
        /// The condition which when returning true will
        /// fire the transition
        /// </summary>
        private Func<bool> _condition;
        public Func<bool> Condition { get { return _condition; } }

        public StateTransition(State to, Func<bool> condition) {
            if(to == null) throw new ArgumentNullException();
            if(condition == null) throw new ArgumentNullException();

            _to = to;
            _condition = condition;
        }

        public bool CanTransition { get { return _condition(); } }
    }
}