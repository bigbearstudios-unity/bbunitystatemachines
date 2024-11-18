
using System.Collections.Generic;

namespace BBUnity.StateMachines {

    /// <summary>
    /// 
    /// </summary>
    sealed public class StateParameter {
        private string _key;
        private State _state;
        private bool _setCurrentState;

        public string Key { get { return _key; } }
        public State State { get { return _state; } }
        public bool SetCurrentState { get { return _setCurrentState; } }

        public StateParameter(string key, State state, bool setCurrentState = false) {
            if(key == null) throw new System.ArgumentNullException("key");
            if(state == null) throw new System.ArgumentNullException("state");

            _key = key;
            _state = state;
            _setCurrentState = setCurrentState;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class StateParameters : List<StateParameter> {
        public void Add(string key, State state, bool setCurrentState = false) {
            Add(new StateParameter(key, state, setCurrentState));
        }
    }
}