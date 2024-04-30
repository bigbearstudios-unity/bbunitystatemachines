
using System.Collections.Generic;

namespace BBUnity.StateMachines {
    public class StateParameters : List<StateParameter> {
        public void Add(string key, State state, bool setCurrentState = false) {
            Add(new StateParameter(key, state, setCurrentState));
        }
    }
}