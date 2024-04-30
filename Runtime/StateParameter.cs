using System;

namespace BBUnity.StateMachines {
    /// <summary>
    /// Representation of a single set of state parameters
    /// </summary>
    public class StateParameter {
        private string _key;
        private State _state;
        private bool _setCurrentState;

        public string Key { get { return _key; } }
        public State State { get { return _state; } }
        public bool SetCurrentState { get { return _setCurrentState; } }

        public StateParameter(string key, State state, bool setCurrentState = false) {
            if(key == null) throw new ArgumentNullException("key");
            if(state == null) throw new ArgumentNullException("state");

            _key = key;
            _state = state;
            _setCurrentState = setCurrentState;
        }
    }
}